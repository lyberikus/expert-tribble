var highscorerApp = angular.module('highscorerApp');

highscorerApp.controller('IndexController', ['$scope','StartService', function IndexController($scope, StartService) {
    vm = this;
    getPlayableGames();
    
    function getPlayableGames() {
        StartService.getPlayableGames().$promise.then(function(playableGames) {
            vm.playableGames = playableGames;
        });
    }
}]);