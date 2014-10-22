(function () {

    var injectParams = ['$scope', 'titleService'];

    var titlesController = function ($scope, titleService) {

        init();

        $scope.orderBy = 'TitleName';
        $scope.txtSearch = '';       

        function init() {
            $scope.titles = [];
            $scope.titleNames = [];
            titleService.getAll()
            .then(function (data) {
                $scope.titleNames = data;
            });

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