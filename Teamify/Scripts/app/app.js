(function() {
    'use strict';

    angular.module('teamify.app', ['ngMaterial', 'ngMessages', 'angular-rating'])
        .config(configFunction);

    configFunction.$inject = ['$mdThemingProvider'];
    function configFunction($mdThemingProvider) {
        $mdThemingProvider.theme('default')
            .primaryPalette('blue-grey')
            .accentPalette('blue');
    }

})();