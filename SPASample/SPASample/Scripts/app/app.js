var spaSampleApp = angular.module("spaSampleApp", ['ngRoute']);

spaSampleApp.config(function ($routeProvider) {
    $routeProvider.when('/', {
        controller: 'screenController',
        templateUrl: '/SPAView/screen.html'
    }).otherwise({ redirectTo: '/' });
});