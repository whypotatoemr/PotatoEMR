window.popupStartDrag = function (dotnetRef, startX, startY) {
    function moveHandler(e) {
        dotnetRef.invokeMethodAsync('OnDrag', e.clientX, e.clientY);
    }
    function upHandler() {
        document.removeEventListener('mousemove', moveHandler);
        document.removeEventListener('mouseup', upHandler);
    }
    document.addEventListener('mousemove', moveHandler);
    document.addEventListener('mouseup', upHandler);
};