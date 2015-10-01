var gulp = require("gulp"),
    util = require("gulp-util"),
    qunit = require("gulp-qunit");

gulp.task("default", function() {

    var tests = "./test/tests.html";

    util.log("Running these tests: " + tests);

    return gulp
        .src(tests)
        .pipe(qunit());
});

gulp.task("make-globalize-cldr-data-js", function() {
  var locale = 'de';
  var jsonWeNeed = [
    require('./bower_components/cldr-data/supplemental/likelySubtags.json'),
    require('./bower_components/cldr-data/main/' + locale + '/numbers.json'),
    require('./bower_components/cldr-data/supplemental/numberingSystems.json'),
    require('./bower_components/cldr-data/main/' + locale + '/ca-gregorian.json'),
    require('./bower_components/cldr-data/main/' + locale + '/timeZoneNames.json'),
    require('./bower_components/cldr-data/supplemental/timeData.json'),
    require('./bower_components/cldr-data/supplemental/weekData.json')
  ];

  var jsonStringWithLoad = 'Globalize.load(' + jsonWeNeed.map(function(json){ return JSON.stringify(json); }).join(', ') + ');';

  var fs = require('fs');
  fs.writeFile('./test/globalize-cldr-data.js', jsonStringWithLoad, function(err) {
      if(err) {
          console.log(err);
      } else {
          console.log("The file was saved!");
      }
  });
});
