(function() {
    'use strict';

    angular.module('teamify.app').service('activityService', service);

    service.$inject = ['$http'];
    function service($http) {

        this.addActivity = addActivity;

        function addActivity(activity) {
            return $http.post('/api/Activity/AddActivity', activity);
        }
    }

})();