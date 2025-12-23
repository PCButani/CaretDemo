document.addEventListener("DOMContentLoaded", () => {
  // init lucide icons (safe)
  if (window.lucide) {
    lucide.createIcons();
  }

  const groups = document.querySelectorAll(".nav-group");
  groups.forEach(group => {
    const header = group.querySelector(".group-header");
    if (!header) return;

    header.addEventListener("click", () => {
      group.classList.toggle("is-collapsed");
      const expanded = !group.classList.contains("is-collapsed");
      header.setAttribute("aria-expanded", expanded ? "true" : "false");
    });
  });

  // Auto-open the group that contains the active item
  const active = document.querySelector(".nav-item.active");
  if (active) {
    const activeGroup = active.closest(".nav-group");
    if (activeGroup) {
      activeGroup.classList.remove("is-collapsed");
      const header = activeGroup.querySelector(".group-header");
      if (header) header.setAttribute("aria-expanded", "true");
    }
  }
});
document.addEventListener("DOMContentLoaded", () => {
  // init lucide icons (safe)
  if (window.lucide) {
    lucide.createIcons();
  }

  const groups = document.querySelectorAll(".nav-group");
  groups.forEach(group => {
    const header = group.querySelector(".group-header");
    if (!header) return;

    header.addEventListener("click", () => {
      group.classList.toggle("is-collapsed");
      const expanded = !group.classList.contains("is-collapsed");
      header.setAttribute("aria-expanded", expanded ? "true" : "false");
    });
  });

  // Auto-open the group that contains the active item
  const active = document.querySelector(".nav-item.active");
  if (active) {
    const activeGroup = active.closest(".nav-group");
    if (activeGroup) {
      activeGroup.classList.remove("is-collapsed");
      const header = activeGroup.querySelector(".group-header");
      if (header) header.setAttribute("aria-expanded", "true");
    }
  }
});
