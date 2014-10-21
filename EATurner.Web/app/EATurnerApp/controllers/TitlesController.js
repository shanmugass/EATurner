(function () {

    var injectParams = ['$scope', 'titleService'];

    var titlesController = function ($scope, titleService) {

        init();

        function init() {
            $scope.titles = [];
        }

        $scope.searchTitles = function () {
            if ($scope.titleSearchForm.$error.required == null) {
                titleService.getBySearchText($scope.txtSearch)
                .then(function (data) {
                    $scope.titles = data;
                });
            }
        }
    };

    titlesController.$inject = injectParams;

    angular.module('EATurnerApp').controller('titlesController', titlesController);

}());