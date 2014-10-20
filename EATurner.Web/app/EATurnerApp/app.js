(function () {

    var app = angular.module('EATurnerApp',
        ['ngRoute', 'ngAnimate', 'wc.directives', 'ui.bootstrap', 'breeze.angular']);

    app.config(['$routeProvider', function ($routeProvider) {
        var viewBase = '/app/EATurnerApp/views/';

        $routeProvider
            .when('/titles', {
                controller: 'TitlesController',
                templateUrl: viewBase + 'titles/titles.html'
            })
            .when('/about', {
                controller: 'AboutController',
                templateUrl: viewBase + 'about.html'
            })
            .otherwise({ redirectTo: '/titles' });

    }]);

    app.run(['$rootScope', '$location', 'authService',
        function ($rootScope, $location, authService) {
            
            //Client-side security. Server-side framework MUST add it's 
            //own security as well since client-based security is easily hacked
            $rootScope.$on("$routeChangeStart", function (event, next, current) {
                if (next && next.$$route && next.$$route.secure) {
                    if (!authService.user.isAuthenticated) {
                        $rootScope.$evalAsync(function () {
                            authService.redirectToLogin();
                        });
                    }
                }
            });

        }]);

}());

