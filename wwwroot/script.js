// blazor can handle drag and drop without js interop
// just need this to stop showing not allowed cursor
document.addEventListener("dragover", (event) => {
    event.preventDefault();
    document.body.style.cursor = "move";
    console.log("dragover");
});

document.addEventListener("dragleave", () => {
    document.body.style.cursor = "";
});