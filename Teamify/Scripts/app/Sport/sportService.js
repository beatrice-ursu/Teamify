(function() {
    'use strict';

    angular.module('teamify.app').service('sportService', service);

    service.$inject = ['$http'];
    function service($http) {
        this.getAvailableSports = getAvailableSports;

        function getAvailableSports() {
            return $http.get('/api/Sport/GetAvailable');
        }
    }
})();