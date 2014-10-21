(function () {

    var injectParams = ['$http', '$rootScope'];

    var dataFactory = function ($http, $rootScope) {

        var factory = {};
        factory.titles = [];

        factory.fillFactory = function (titles) {
            factory.titles = titles;
        };

        factory.getTitleFromFactory = function (titleId) {
            var title = {};
            if (factory.titles.length == 0) return title;
        };

        return factory;
    };

    dataFactory.$inject = injectParams;

    angular.module('EATurnerApp').factory('dataService', dataFactory);

}());

