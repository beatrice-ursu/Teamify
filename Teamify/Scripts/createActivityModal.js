(function () {
    'use strict';

    var createButton = $('#create-activity-button');
    createButton.click(createButtonClickHandler);

    var model = {
        date: $('#date'),
        expireDate: $('#expireDate'),
        minPlayers: $('#minPlayers'),
        maxPlayers: $('#maxPlayers'),
        minPlayersRating: $('#minPlayersRating'),
        description: $('#description')
    };

    function createButtonClickHandler(e) {
        $.ajax({
            url: '/api/Activity/Create',
            type: 'POST',
            data: {
                Date: model.date.val(),
                ExpireDate: model.expireDate.val(),
                MinPlayers: model.minPlayers.val(),
                MaxPlayers: model.maxPlayers.val(),
                MinPlayersRating: model.minPlayersRating.val(),
                Description: model.description.val()
            },
            success: function(result) {
                alert(result.someValue);
            },
            error: function(err) {
                console.log(err);
            }
        });
    }
})();