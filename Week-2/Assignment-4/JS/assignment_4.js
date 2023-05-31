window.onload = function() {
    let header_block = document.querySelector('.header_block');
    let header_content = document.querySelector('.header_content');
    header_block.addEventListener('click', () => {
        header_content.textContent = "Have a Good Time!";
    });

    let btn_callToAction = document.querySelector('.btn_callToAction_contain');
    let moreContentBoxes_block = document.querySelector('.moreContentBoxes');
    btn_callToAction.addEventListener('click', () => {
        moreContentBoxes_block.style.display = 'flex';
     });
}