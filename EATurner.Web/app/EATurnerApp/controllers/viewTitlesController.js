(function () {

    var injectParams = ['$scope', '$routeParams', 'titleService'];

    var viewTitlesController = function ($scope, $routeParams, titleService) {

        var titleId = ($routeParams.titleId) ? parseInt($routeParams.titleId) : 0;

        $scope.title = {};
        $scope.showNotFound = 1;

        init();

        function init() {
            if (titleId > 0) {
                titleService.getById(titleId)
                 .then(function (data) {
                     $scope.title = data;
                     $scope.showNotFound = 0;
                 });
            }
        };
    };

    viewTitlesController.$inject = injectParams;

    angular.module('EATurnerApp').controller('viewTitlesController', viewTitlesController);

}());