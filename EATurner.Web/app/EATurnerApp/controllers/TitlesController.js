(function () {

    var injectParams = ['$scope', 'titleService'];

    var titlesController = function ($scope, titleService) {

        init();

        $scope.orderBy = 'TitleName';

        function init() {
            $scope.titles = [];
        }

        $scope.setOrder = function (orderColumn) {
            $scope.orderBy = orderColumn;
        };

        $scope.searchTitles = function () {
            if ($scope.titleSearchForm.$error.required == null) {
                titleService.getBySearchText($scope.txtSearch)
                .then(function (data) {
                    $scope.orderBy = 'TitleName';
                    $scope.titles = data;
                });
            }
        }
    };

    titlesController.$inject = injectParams;

    angular.module('EATurnerApp').controller('titlesController', titlesController);

}());