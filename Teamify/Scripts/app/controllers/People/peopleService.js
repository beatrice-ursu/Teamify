(function () {
    'use strict';

    angular.module('teamify.app').service('peopleService', service);

    service.$inject = ['$http'];
    function service($http) {
        this.getPeople = getPeople;

        function getPeople() {
            return $http.get('/api/People/GetPeople');
        }
    }
})();