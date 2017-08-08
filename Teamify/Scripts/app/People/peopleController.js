(function () {
    'use strict';

    angular.module('teamify.app').controller('peopleController', controller);

    controller.$inject = ['peopleService'];
    function controller(peopleService) {
        var vm = this;

        init();

        function init() {
            peopleService.getPeople().then(getPeopleSuccess, failFunction);
        }

        function getPeopleSuccess(response) {
            vm.people = response.data;
        }

        function failFunction(error) {
            
        }

    }

})();