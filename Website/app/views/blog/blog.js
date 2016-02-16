'use strict';

angular.module('myApp.blog', ['ngRoute'])

.config(['$routeProvider', function($routeProvider) {
  $routeProvider.when('/blog', {
    templateUrl: 'views/blog/blog.html',
    controller: 'BlogCtrl'
  });
}])

.controller('BlogCtrl', [function() {

}]);