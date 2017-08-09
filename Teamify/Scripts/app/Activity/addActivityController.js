(function() {
    'use strict';

    angular.module('teamify.app').controller('addActivityController', controller);

    controller.$inject = ['$mdDialog', 'activityService', 'sportService', 'peopleService', '$filter', '$mdToast'];
    function controller($mdDialog, activityService, sportService, peopleService, $filter, $mdToast) {
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
            selectedItem: null,
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
            },
            onChange: function() {
                vm.activity.SportId = this.selectedItem.Value;
            }
        };

        vm.peopleOptions = {
            getPeopleFiltered: function (filter) {
                return peopleService.getPeopleFiltered(filter, vm.activity.InvitedPeople).then(
                    function(response) {
                        return response.data;
                    });
            }
        };

        vm.save = function() {
            if (vm.createActivity.$valid) {
                activityService.addActivity(vm.activity).then(_addActivitySuccess, _addActivityFail);
            }
        };

        function _addActivitySuccess(response) {
            $mdToast.showSimple('Activity created successfully!');
            $mdDialog.hide();
        }

        function _addActivityFail(err) {
            $mdToast.showSimple('Activity creation failed! Please try again.');
        }

        vm.cancel = function () {
            $mdDialog.cancel();
        };

        init();

        function init() {
            vm.sportsOptions.initDataSource();
        }
    }

})();