(function () {

    var app = angular.module('EATurnerApp',
        ['ngRoute', 'ngAnimate', 'wc.directives', 'ui.bootstrap', 'mgcrea.ngStrap']);

    app.config(['$routeProvider', function ($routeProvider) {
        var viewBase = '/app/EATurnerApp/views/';

        $routeProvider
            .when('/titles', {
                controller: 'titlesController',
                templateUrl: viewBase + 'titles/titles.html'
            })
            .when('/viewTitle/:titleId', {
                controller: 'viewTitlesController',
                templateUrl: viewBase + 'titles/viewTitle.html'
            })
            .when('/about', {
                controller: 'aboutController',
                templateUrl: viewBase + 'about.html'
            })
            .otherwise({ redirectTo: '/titles' });

    }]);

    //app.run(['$rootScope', '$location', 'authService',
    //    function ($rootScope, $location, authService) {

    //        //Client-side security. Server-side framework MUST add it's 
    //        //own security as well since client-based security is easily hacked
    //        $rootScope.$on("$routeChangeStart", function (event, next, current) {
    //            if (next && next.$$route && next.$$route.secure) {
    //                if (!authService.user.isAuthenticated) {
    //                    $rootScope.$evalAsync(function () {
    //                        authService.redirectToLogin();
    //                    });
    //                }
    //            }
    //        });

    //    }]);

}());

