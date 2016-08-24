angular.module("MyApp")
       .controller("appuserCtrl", ['$scope', function ($scope) {
           $scope.pageTitle = 'App Users';
           $scope.message = 'This is the message from controller to view on page';
       }]);
