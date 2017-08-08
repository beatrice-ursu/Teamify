(function () {
    'use strict';

    angular.module('teamify.app').service('peopleService', service);

    service.$inject = ['$http'];
    function service($http) {
        this.getPeople = getPeople;
        this.filterPeople = filterPeople;

        function getPeople() {
            return $http.get('/api/People/GetPeople');
        }

        function filterPeople(filter, out) {
            return $http.get(`/api/People/Filter/${filter}/${out}`);
        }
    }

})(); 