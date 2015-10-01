var gulp = require("gulp");

var del = require("del");
var gulpUtil = require("gulp-util");
var path = require("path");
var remoteSrc = require('gulp-remote-src');
var wiredep = require("wiredep");

var config = require("./gulpfile.config.js");

/**
 * Get the scripts or styles the app requires based on bower dependencies
 *
 * @param {string} jsOrCss Should be "js" or "css"
 */
function getBowerScriptsOrStyles(jsOrCss) {

    gulpUtil.log("Getting " + jsOrCss + " from Bower using Wiredep"/* + JSON.stringify(wiredep(config.wiredepOptions)["js"])*/);

    var bowerScriptsOrStylesAbsolute = wiredep(config.wiredepOptions)[jsOrCss] || [];

    gulpUtil.log(JSON.stringify(bowerScriptsOrStylesAbsolute));

    var bowerScriptsOrStylesRelative = bowerScriptsOrStylesAbsolute.map(function makePathRelativeToCwd(file) {
        return path.relative("", file);
    });

    //gulpUtil.log(jsOrCss + " relative:\n" + JSON.stringify(bowerScriptsOrStylesRelative));

    return bowerScriptsOrStylesRelative;
}

gulp.task("clean", function (cb) {

    gulpUtil.log("Delete installed bower assets and build folder");

    return del([
        "./bower_components"
    ], { force: false },
    cb);
});

gulp.task("clean-bower-local", function (cb) {

    gulpUtil.log("Delete installed bower assets and build folder");

    return del([
        "./content/bootstrap",
        "./content/fonts",
        "./scripts/*.js"
    ], { force: false },
    cb);
});

gulp.task("bower-copy-local-css", ["clean-bower-local"], function () {

    return gulp
        .src(getBowerScriptsOrStyles("css"))
        .pipe(gulp.dest(config.localCssDir));
});

gulp.task("bower-copy-local-bootstrap-less", ["clean-bower-local"], function () {

    return gulp
        .src("./bower_components/bootstrap/less/**/*.*")
        .pipe(gulp.dest(config.localBootstrapDir));
});

gulp.task("bower-copy-local-fonts", ["clean-bower-local"], function () {

    return gulp
        .src("./bower_components/bootstrap/fonts/*.*")
        //.pipe(print())
        .pipe(gulp.dest(config.localFontsDir));
});

gulp.task("bower-copy-local-js", ["clean-bower-local"], function () {

    var filesToUse = [].concat(getBowerScriptsOrStyles("js"), [
        // jQuery Validation does not include additional-methods.js in its bower.json
        "./bower_components/jquery-validation/dist/additional-methods.js"
    ]);

    return gulp
        .src(filesToUse)
        .pipe(gulp.dest(config.localJsDir));
});

// Read bower-install.md for information
gulp.task("bower-copy-local", [
    "bower-copy-local-css",
    "bower-copy-local-bootstrap-less",
    "bower-copy-local-fonts",
    "bower-copy-local-js"
], function () { });

gulp.task("delete-bootswatch", function (cb) {

    gulpUtil.log("Delete installed bower assets and build folder");

    return del([
        "./content/bootswatch.less",
        "./content/variables.less"
    ], { force: false },
    cb);
});

gulp.task("get-bootswatch", ["delete-bootswatch"], function () {

    return remoteSrc(["bootswatch.less", "variables.less"], {
            base: "http://bootswatch.com/cerulean/",
        })
        .pipe(gulp.dest(config.localCssDir));
});


gulp.task("default", [ "bower-copy-local" ],
    function () {
        // place code for your default task here
    });
