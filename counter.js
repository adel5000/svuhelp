const countEl = document.getElementById("counter");

updateVisitCount();

function updateVisitCount() {
  fetch(
    "https://api.countapi.xyz/update/svuhelp.org/df52e842-986d-4cb9-927d-505357d25f98?amount=1"
  )
    .then((res) => res.json())
    .then((res) => {
      countEl.innerHTML = res.value;
    });
}

// SOCIAL PANEL JS
const floating_btn = document.querySelector(".floating-btn");
const close_btn = document.querySelector(".close-btn");
const social_panel_container = document.querySelector(
  ".social-panel-container"
);

floating_btn.addEventListener("click", () => {
  social_panel_container.classList.toggle("visible");
});

close_btn.addEventListener("click", () => {
  social_panel_container.classList.remove("visible");
});
