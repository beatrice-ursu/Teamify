(function() {
    angular.module('teamify.app').controller('headerController', controller);

    controller.$inject = ['$mdDialog'];
    function controller($mdDialog) {
        var vm = this;

        vm.openCreateActivityModal = function(ev) {
            $mdDialog.show({
                controller: 'addActivityController',
                controllerAs: 'vm',
                bindToController: true,
                templateUrl: '/Scripts/app/controllers/Activity/addActivityTemplate.html',
                parent: angular.element(document.body),
                targetEvent: ev,
                clickOutsideToClose: false
            }).then(successFunction, failFunction);
        };

        function successFunction() {
            
        }

        function failFunction() {
            
        }
    }
})();