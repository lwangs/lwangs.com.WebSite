
$(function () { 

    $("#btn_ReadEnglish").click(function () { 
        var audio = document.getElementById('btnPlayAudio');
        if (audio !== null) {
            //检测播放是否已暂停.audio.paused 在播放器播放时返回false. 
            if (audio.paused) {
                audio.play();//audio.play();// 这个就是播放
            } else {
                audio.pause()
                audio.currentTime = 0; 
            }
        } 
    });


});