(function () {
    "use strict";

    WinJS.UI.Pages.define("/pages/itemDetail/itemDetail.html", {
        // This function is called whenever a user navigates to this page. It
        // populates the page elements with the app's data.
        ready: function (element, options) {
            var item = options && options.item ? Data.resolveItemReference(options.item) : Data.items.getAt(0);
            element.querySelector(".titlearea .pagetitle").textContent = item.description;

            retrieveMeetingAgenda(item.url);
        }
    });

    function retrieveMeetingAgenda(agendaUrl) {
        WinJS.xhr({ url: agendaUrl })
            .then(function (xhr) {
                var response = $(xhr.response);

                // get #content direct .paragraph childs
                var sections = $("#content > .paragraph", response);

                // get agenda section
                var agenda = $(sections[1]);

                // get all sessions videos
                agenda.find("a[href^='http://netponto.org/sessao']").each(function (idx, elem) {
                    retrieveSessionVideo($(elem).attr("href"));
                });

                // remove all anchors to external sites
                agenda.find("a").replaceWith(function () {
                    return $(this).text();
                });

                // appenda html to screen
                var element = WinJS.Utilities.query(".agenda .item-content");
                WinJS.Utilities.setInnerHTML(element[0], toStaticHTML(agenda[0].outerHTML));
            });
    }

    function retrieveSessionVideo(sessionUrl) {
        WinJS.xhr({ url: sessionUrl })
            .then(function (xhr) {
                var response = $(xhr.response);

                // get video iframe
                var iframe = $("#content iframe[src^='http://www.youtube.com']", response);
                if (iframe.length == 0)
                    return;

                var element = WinJS.Utilities.query(".videos .item-content");
                WinJS.Utilities.setInnerHTMLUnsafe(element[0], element[0].innerHTML + "<div class='video'>" + iframe[0].outerHTML + "</div>");
            });
    }
})();
