﻿(function () {
    'use strict';

    angular.module('teamify.app').controller('headerController', controller);

    controller.$inject = ['$mdDialog'];
    function controller($mdDialog) {
        var vm = this;

        vm.openCreateActivityModal = function(ev) {
            $mdDialog.show({
                controller: 'addActivityController',
                controllerAs: 'vm',
                templateUrl: '/Scripts/app/controllers/Activity/addActivityTemplate.html',
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