const openedWidth = "400px";
const openedHeight = "300px";

const player = document.querySelector("#overlay");


function changePreviewState(projectElement) {
    if (projectElement.parentElement.querySelector(".project-preview.hidden") !== null) {
        showPreview(projectElement);
    }
    else {
        hidePreview(projectElement);
    }
}

function showPreview(projectElement) {
    const videoElement = projectElement.parentElement.querySelector(".project-preview.hidden");
    videoElement.setAttribute("class", "project-preview");
    document.querySelector("#projects");
}

function hidePreview(projectElement) {
    const videoElement = projectElement.parentElement.querySelector(".project-preview");
    videoElement.setAttribute("class", "project-preview hidden");
}

function enablePlayer(video) {
    player.children[0].setAttribute("src", video);
    player.style.display = "block";
}

function disablePlayer() {
    player.children[0].setAttribute("src", "");
    player.style.display = "none";
}