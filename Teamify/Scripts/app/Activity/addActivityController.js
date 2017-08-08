(function() {
    'use strict';

    angular.module('teamify.app').controller('addActivityController', controller);

    controller.$inject = ['$mdDialog', 'sportService', '$filter'];
    function controller($mdDialog, sportService, $filter) {
        var vm = this;

        vm.activity = {
            Date: new Date(),
            ExpireDate: new Date(),
            MinPlayers: 2,
            MaxPlayers: 4,
            MinPlayersRating: 4,
            InvitedPeople: [],
            //todo: integrate with google maps
            LocationId: 'some random stuff'
        };

        vm.sportsOptions = {
            searchText: null,
            dataSource: [],
            initDataSource: function() {
                sportService.getAvailableSports().then(function(response) {
                    vm.sportsOptions.dataSource = response.data;
                });
            },
            getSportsFiltered: function() {
                return vm.sportsOptions.searchText
                    ? $filter('filter')(vm.sportsOptions.dataSource, vm.sportsOptions.searchText)
                    : vm.sportsOptions.dataSource;
            }
        };

        vm.save = function () {
            $mdDialog.hide();
        };

        vm.cancel = function () {
            $mdDialog.cancel();
        };

        init();

        function init() {
            vm.sportsOptions.initDataSource();
        }
    }

})();