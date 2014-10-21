(function () {

    var injectParams = ['$http', '$rootScope'];

    var titleFactory = function ($http, $rootScope) {
        var serviceBase = '/api/titles/'

        factory = {};

        factory.getAll = function () {
            return $http.get(serviceBase).then(
                function (results) {
                    return results.data;
                });
        };

        factory.getById = function (id) {
            return $http.get(serviceBase + '/' + id).then(
                function (results) {
                    return results.data;
                });
        };

        factory.getBySearchText = function (searchKey) {
            return $http.get(serviceBase + '/' + searchKey).then(
                function (results) {
                    return results.data;
                });
        };

        return factory;
    };

    titleFactory.$inject = injectParams;

    angular.module('EATurnerApp').factory('titleService', titleFactory);

}());

