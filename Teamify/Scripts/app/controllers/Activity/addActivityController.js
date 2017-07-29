(function() {
    'use strict';

    angular.module('teamify.app').controller('addActivityController', controller);

    controller.$inject = ['$mdDialog'];
    function controller($mdDialog) {
        var vm = this;

        vm.title = 'Somehting';
        vm.activity = {};

        vm.valuesDataSource = [1, 2, 3, 4];

        vm.hide = function () {
            $mdDialog.hide();
        };

        vm.cancel = function () {
            $mdDialog.cancel();
        };

        vm.answer = function (answer) {
            $mdDialog.hide(answer);
        };
    }

})();