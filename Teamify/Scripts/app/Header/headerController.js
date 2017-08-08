(function () {
    'use strict';

    angular.module('teamify.app').controller('headerController', controller);

    controller.$inject = ['$mdDialog'];
    function controller($mdDialog) {
        const vm = this;

        vm.openCreateActivityModal = function(ev) {
            $mdDialog.show({
                controller: 'addActivityController',
                controllerAs: 'vm',
                bindToController: true,
                templateUrl: '/Scripts/app/Activity/addActivityTemplate.html',
                parent: angular.element(document.body),
                targetEvent: ev,
                clickOutsideToClose: false
            }).then(successFunction, failFunction);
        };

        vm.peoplePage = function() {
            alert("cv");
        };

        function successFunction() {
            
        }

        function failFunction() {
            
        }
    }
})();