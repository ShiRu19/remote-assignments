window.onload = function() {
    $('.header_block').click(function() {
        $('.header_content').text("Have a Good Time!");
    });

    $('.btn_callToAction_contain').click(function() {
        $('.moreContentBoxes').css('display', 'flex');
    });
}