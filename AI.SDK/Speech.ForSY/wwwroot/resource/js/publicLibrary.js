//禁止页面滑动
function disableTouchMove() {
    document.getElementById("speechMainContainer").addEventListener("touchmove", function (e) {
        e.preventDefault();
    });
    document.getElementById("disablePageSlide").addEventListener("touchmove", function (e) {
        e.preventDefault();
    });
}

//禁止页面双击放大操作
function disableDoubleClick() {
    var lastTouchEnd = 0;
    document.documentElement.addEventListener("touchend", function (event) {
        var now = Date.now();
        if (now - lastTouchEnd <= 300) {
            event.preventDefault();
        }
        lastTouchEnd = now;
    }, false);
}
 
//判断当前屏幕方向   显示对应的模板
function setContentByOrientationChange() {
    window.addEventListener("orientationchange", function () {
        if (window.orientation == 0)
            $(".tiprevolvephone").css("display", "block");
        else
            $(".tiprevolvephone").css("display", "none");
    }, false);
}
 
//禁止页面link跳转默认safari
function setVisitorOnDeskSystem() {
    if (('standalone' in window.navigator) && window.navigator.standalone) {
        var noddy, remotes = false;
        document.addEventListener('click', function (event) {
            noddy = event.target;
            while (noddy.nodeName !== 'A' && noddy.nodeName !== 'HTML') noddy = noddy.parentNode;
            if ('href' in noddy && noddy.href.indexOf('http') !== -1 && (noddy.href.indexOf(document.location.host) !== -1 || remotes)) {
                event.preventDefault();
                document.location.href = noddy.href;
            }
        }, false);
    } 
}


$(function () {
    //if (window.orientation == 0) {
    //    $(".tiprevolvephone").css("display", "block");
    //}
    //disableTouchMove();
    //disableDoubleClick();
    //setContentByOrientationChange();
    //setVisitorOnDeskSystem();
});