var controllers = {};

controllers.screenController = function ($scope, ScreenFactory) {
    $scope.screens = [];
    $scope.fields = null;
    initialize();


    function initialize() {
        ScreenFactory.getScreens().success(function (data) {
            $scope.screens = data;
        }).error(function (data) {
            if (data && data.Message) {
                alert(data.Message);
            }
            else {
                alert('Error on server.');
            }
        });
    }

    $scope.fillFields = function (id) {
        ScreenFactory.getScreen(id).success(function (data) {
            $scope.fields = data.Fields;
        }).error(function (data) {
            if (data && data.Message) {
                alert(data.Message);
            }
            else {
                alert('Error on server.');
            }
        });
    };
};

spaSampleApp.controller(controllers);