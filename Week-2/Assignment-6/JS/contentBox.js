function contentBoxClick(contentBox) {
    //var x = document.getElementsByClassName('contentBox')[0];
    if(contentBox.getAttribute("data-status") == "unclick") {
        contentBox.dataset.status = "click";
    }
    else {
        contentBox.dataset.status = "unclick";
    }
}