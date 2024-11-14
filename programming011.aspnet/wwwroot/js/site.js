// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
document.addEventListener("DOMContentLoaded", function () {
    const sidebar = document.getElementById("animatedSidebar");

    // Show sidebar after a delay (e.g., 1 second)
    setTimeout(() => {
        sidebar.classList.add("show");
    }, 1000);

    setTimeout(() => {
        sidebar.classList.remove("show");
    }, 5000);
});

