angular.
  module('highscorerApp').
  config(['$locationProvider', '$routeProvider',
    function config($locationProvider, $routeProvider) {
        $locationProvider.html5Mode(true)

        $routeProvider
            .when('/', {
                templateUrl: "app/start/start.html",
                controller: "IndexController as vm"
            })
            .when("/bowling", {
                templateUrl: "app/bowling/bowling.html"
            })
    }
  ]);