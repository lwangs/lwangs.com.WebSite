
$(function () {

    $(".translatesContainer").first().css("display", "block");

    $(".englishValue").click(function () {

        $.ajax({
            url: '/api/ApiRead',
            type: 'get', //GET
            async: false,    //或false,是否异步
            data: { "englishID": $(this).attr("data-ID"), "english": $(this).attr("data-english"), "chiness": $(this).attr("data-chiness") },
            beforeSend: function (xhr) {
                console.log(xhr)
                console.log('发送前')
            },
            success: function (data, textStatus, jqXHR) {
                if (data != '') {
                    $("#btnPlayAudio").attr("src", "/audio/" + data + ".mp3");
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
                }
            },
            error: function (xhr, textStatus) {
                console.log('错误', xhr.responseText);
                console.log(xhr);
                console.log(textStatus);
            }
        })


    });

    $("#btn_Next").click(function () { 
        var nextShow = Number($(".translatesContainer:visible").show().attr("data-orderBy")) + 1;
        
        $(".translatesContainer").each(function () {

            if (Number($(this).attr("data-orderBy")) == nextShow) {
                $(".translatesContainer").hide();
                $(this).show();
            }
        });
         

    });


});