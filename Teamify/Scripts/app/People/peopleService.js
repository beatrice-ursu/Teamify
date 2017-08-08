(function () {
    'use strict';

    angular.module('teamify.app').service('peopleService', service);

    service.$inject = ['$http'];
    function service($http) {
        this.getPeople = getPeople;
        this.getPeopleFiltered = getPeopleFiltered;

        function getPeople() {
            return $http.get('/api/People/GetPeople');
        }

        function getPeopleFiltered(filter, out) {
            return $http.post(`/api/People/Filter/${filter == null ? '' : filter}`, out);
        }
    }

})(); 