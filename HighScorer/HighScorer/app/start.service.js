var highscorerApp = angular.module('highscorerApp');

highscorerApp.service('StartService', ['$resource', function StartService($resource) {
    var startResource = $resource('/api/GetPlayableGames');
        return {
            getPlayableGames: startResource.query
        }
}]);