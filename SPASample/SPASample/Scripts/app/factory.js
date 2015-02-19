spaSampleApp.factory('ScreenFactory', function ($http) {
    var factory = {};

    factory.getScreens = function () {
        return $http.get('/api/screen')
    };

    factory.getScreen = function (id) {
        return $http.get('/api/screen/' + id)
    };

    return factory;
});