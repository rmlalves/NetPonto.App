(function () {
    "use strict";

    var list = new WinJS.Binding.List();
    var groupedItems = list.createGrouped(
        function groupKeySelector(item) { return item.group.key; },
        function groupDataSelector(item) { return item.group; }
    );

    //dummy_retrieveMeetings();
    retrieveMeetings();

    WinJS.Namespace.define("Data", {
        items: groupedItems,
        groups: groupedItems.groups,
        getItemReference: getItemReference,
        getItemsFromGroup: getItemsFromGroup,
        resolveGroupReference: resolveGroupReference,
        resolveItemReference: resolveItemReference
    });

    // Get a reference for an item, using the group key and item title as a
    // unique reference to the item that can be easily serialized.
    function getItemReference(item) {
        return [item.group.key, item.title];
    }

    // This function returns a WinJS.Binding.List containing only the items
    // that belong to the provided group.
    function getItemsFromGroup(group) {
        return list.createFiltered(function (item) { return item.group.key === group.key; });
    }

    // Get the unique group corresponding to the provided group key.
    function resolveGroupReference(key) {
        for (var i = 0; i < groupedItems.groups.length; i++) {
            if (groupedItems.groups.getAt(i).key === key) {
                return groupedItems.groups.getAt(i);
            }
        }
    }

    // Get a unique item from the provided string array, which should contain a
    // group key and an item title.
    function resolveItemReference(reference) {
        for (var i = 0; i < groupedItems.length; i++) {
            var item = groupedItems.getAt(i);
            if (item.group.key === reference[0] && item.title === reference[1]) {
                return item;
            }
        }
    }

    function retrieveMeetings() {
        WinJS.xhr({ url: "http://netponto.org/reuniao/" })
            .then(function (xhr) {
                var response = $(xhr.response);

                var groups = [];
                var items = [];
                $("#content ul", response).each(function (ulIdx, ul) {
                    var $ul = $(ul);
                    var groupName = $ul.prev().text() || $ul.prev().prev().text();
                    if (groupName == '')
                        return;

                    var group = {
                        key: ulIdx + 1, // can't use 0 or layout gets weird
                        title: groupName,
                    };
                    groups.push(group);

                    $("li", $ul).each(function (liIdx, li) {
                        var $li = $(li);
                        var obj = {
                            group: group,
                            title: $li.find("strong").text(),
                            description: $li.find("a").attr('title'),
                            url: $li.find("a").attr('href'),
                        };
                        items.push(obj);

                    });
                });

                // add items to visual list
                items.forEach(function (item) {
                    list.push(item);
                });
            });
    }

    function dummy_retrieveMeetings() {
        var groups = [
            { key: 1, title: "Próximas Reuniões" },
            { key: 2, title: "Coimbra" },
            { key: 3, title: "Lisboa" },
            { key: 4, title: "Porto" },
            { key: 5, title: "Porto Salvo" },
            { key: 6, title: "Viana do Castelo" },
            { key: 7, title: "Vila Real" }
        ];

        var items = [
            { group: groups[0], description: "35ª Reunião Presencial da Comunidade NetPonto em Lisboa", title: "26-01-2013", url: "http://" },
            { group: groups[0], description: "36ª Reunião Presencial da Comunidade NetPonto em Lisboa", title: "23-02-2013", url: "http://" },
            { group: groups[1], description: "5ª Reunião Presencial da Comunidade NetPonto em Coimbra", title: "09-06-2012", url: "http://" },
            { group: groups[1], description: "4ª Reunião Presencial da Comunidade NetPonto em Coimbra", title: "11-02-2012", url: "http://" },
            { group: groups[1], description: "3ª Reunião Presencial da Comunidade NetPonto em Coimbra", title: "19-11-2011", url: "http://" },
            { group: groups[1], description: "2ª Reunião Presencial da Comunidade NetPonto em Coimbra", title: "09-07-2011", url: "http://" },
            { group: groups[1], description: "1ª Reunião Presencial da Comunidade NetPonto em Coimbra", title: "09-04-2011", url: "http://" },
            { group: groups[2], description: "34ª Reunião Presencial da Comunidade NetPonto em Lisboa", title: "08-12-2012", url: "http://" },
            { group: groups[2], description: "33ª Reunião Presencial da Comunidade NetPonto em Lisboa", title: "24-11-2012", url: "http://" },
            { group: groups[2], description: "32ª Reunião Presencial da Comunidade NetPonto em Lisboa", title: "25-08-2012", url: "http://" },
            { group: groups[2], description: "31ª Reunião Presencial da Comunidade NetPonto em Lisboa", title: "21-07-2012", url: "http://" },
            { group: groups[2], description: "30ª Reunião Presencial da Comunidade NetPonto em Lisboa", title: "16-06-2012", url: "http://" },
            { group: groups[2], description: "29ª Reunião Presencial da Comunidade NetPonto em Lisboa", title: "26-05-2012", url: "http://" },
            { group: groups[2], description: "28ª Reunião Presencial da Comunidade NetPonto em Lisboa", title: "21-04-2012", url: "http://" },
            { group: groups[2], description: "27ª Reunião Presencial da Comunidade NetPonto em Lisboa", title: "24-03-2012", url: "http://" },
            { group: groups[2], description: "26ª Reunião Presencial da Comunidade NetPonto em Lisboa", title: "21-01-2012", url: "http://" },
            { group: groups[2], description: "25ª Reunião Presencial da Comunidade NetPonto em Lisboa", title: "17-12-2011", url: "http://" },
            { group: groups[2], description: "24ª Reunião Presencial da Comunidade NetPonto em Lisboa", title: "29-10-2011", url: "http://" },
            { group: groups[2], description: "23ª Reunião Presencial da Comunidade NetPonto em Lisboa", title: "24-09-2011", url: "http://" },
            { group: groups[2], description: "22ª Reunião Presencial da Comunidade NetPonto em Lisboa", title: "23-07-2011", url: "http://" },
            { group: groups[2], description: "21ª Reunião Presencial da Comunidade NetPonto em Lisboa", title: "18-06-2011", url: "http://" },
            { group: groups[2], description: "20ª Reunião Presencial da Comunidade NetPonto em Lisboa", title: "21-05-2011", url: "http://" },
            { group: groups[2], description: "19ª Reunião Presencial da Comunidade NetPonto em Lisboa", title: "16-04-2011", url: "http://" },
            { group: groups[2], description: "18ª Reunião Presencial da Comunidade NetPonto em Lisboa", title: "26-03-2011", url: "http://" },
            { group: groups[2], description: "17ª Reunião Presencial da Comunidade NetPonto em Lisboa", title: "22-01-2011", url: "http://" },
            { group: groups[2], description: "16ª Reunião Presencial da Comunidade NetPonto em Lisboa", title: "11-12-2010", url: "http://" },
            { group: groups[2], description: "15ª Reunião Presencial da Comunidade NetPonto em Lisboa", title: "23-10-2010", url: "http://" },
            { group: groups[2], description: "14ª Reunião Presencial da Comunidade NetPonto em Lisboa", title: "18-09-2010", url: "http://" },
            { group: groups[2], description: "13ª Reunião Presencial da Comunidade NetPonto em Lisboa", title: "14-08-2010", url: "http://" },
            { group: groups[2], description: "12ª Reunião Presencial da Comunidade NetPonto em Lisboa", title: "10-07-2010", url: "http://" },
            { group: groups[2], description: "11ª Reunião Presencial da Comunidade NetPonto em Lisboa", title: "19-06-2010", url: "http://" },
            { group: groups[2], description: "10ª Reunião Presencial da Comunidade NetPonto em Lisboa", title: "15-05-2010", url: "http://" },
            { group: groups[2], description: "9ª Reunião Presencial da Comunidade NetPonto em Lisboa", title: "24-04-2010", url: "http://" },
            { group: groups[2], description: "8ª Reunião Presencial da Comunidade NetPonto em Lisboa", title: "20-03-2010", url: "http://" },
            { group: groups[2], description: "7ª Reunião Presencial da Comunidade NetPonto em Lisboa", title: "27-02-2010", url: "http://" },
            { group: groups[2], description: "6ª Reunião Presencial da Comunidade NetPonto em Lisboa", title: "23-01-2010", url: "http://" },
            { group: groups[2], description: "5ª Reunião Presencial da Comunidade NetPonto em Lisboa", title: "12-12-2009", url: "http://" },
            { group: groups[2], description: "4ª Reunião Presencial da Comunidade NetPonto em Lisboa", title: "21-11-2009", url: "http://" },
            { group: groups[2], description: "3ª Reunião Presencial da Comunidade NetPonto em Lisboa", title: "17-10-2009", url: "http://" },
            { group: groups[2], description: "2ª Reunião Presencial da Comunidade NetPonto em Lisboa", title: "19-09-2009", url: "http://" },
            { group: groups[2], description: "1ª Reunião Presencial da Comunidade NetPonto em Lisboa", title: "15-08-2009", url: "http://" },
            { group: groups[3], description: "2ª Reunião Presencial da Comunidade NetPonto no Porto", title: "14-04-2012", url: "http://" },
            { group: groups[3], description: "1ª Reunião Presencial da Comunidade NetPonto no Porto", title: "27-03-2010", url: "http://" },
            { group: groups[4], description: "Sessão Especial NetPonto: PowerPivot com Alberto Ferrari", title: "13-02-2012", url: "http://" },
            { group: groups[5], description: "1ª Reunião Presencial da Comunidade NetPonto em Viana do Castelo", title: "14-07-2012", url: "http://" },
            { group: groups[6], description: "1ª Reunião Presencial da Comunidade NetPonto em Vila Real", title: "12-02-2011", url: "http://" },
        ];

        // add items to visual list
        items.forEach(function (item) {
            list.push(item);
        });
    }
})();
