'use strict';

describe('myApp.blog module', function() {

  beforeEach(module('myApp.blog'));

  describe('blog controller', function(){

    it('should ....', inject(function($controller) {
      //spec body
      var blogCtrl = $controller('BlogCtrl');
      expect(blogCtrl).toBeDefined();
    }));

  });
});