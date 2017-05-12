$.get('/Layout/GetSportsList',
    function (data) {
        $("#SearchSport")
            .select2({
                data: data
            });
    });
