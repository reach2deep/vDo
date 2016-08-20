angular.module("MyApp")
       .controller("dashboardCtrl", ['$scope', function ($scope) {
           $scope.pageTitle = 'Dashboard';
           $scope.message = 'This is the message from controller to view on page';
       }]);
