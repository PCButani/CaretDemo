document.addEventListener("DOMContentLoaded", function () {
  const headers = document.querySelectorAll(".group-header");
  const panels = document.querySelectorAll(".group-items");

  function closeAll() {
    panels.forEach((p) => p.classList.remove("is-open"));
    headers.forEach((h) => h.setAttribute("aria-expanded", "false"));
  }

  function openGroup(groupKey) {
    const header = document.querySelector(`.group-header[data-group="${groupKey}"]`);
    const panel = document.querySelector(`.group-items[data-group-items="${groupKey}"]`);
    if (!header || !panel) return;

    closeAll();
    panel.classList.add("is-open");
    header.setAttribute("aria-expanded", "true");
  }

  // Click: open only one group at a time
  headers.forEach((header) => {
    header.addEventListener("click", function () {
      const groupKey = header.getAttribute("data-group");
      const panel = document.querySelector(`.group-items[data-group-items="${groupKey}"]`);
      if (!panel) return;

      const isOpen = panel.classList.contains("is-open");
      closeAll();
      if (!isOpen) openGroup(groupKey);
    });
  });

  // Auto-open the group containing the active page
  const activeSub = document.querySelector(".nav-subitem.active");
  if (activeSub) {
    const panel = activeSub.closest(".group-items");
    if (panel) {
      const groupKey = panel.getAttribute("data-group-items");
      if (groupKey) openGroup(groupKey);
    }
  } else {
    // Default open
    openGroup("dashboards");
  }

  // Render Lucide icons again (because sidebar HTML is present on load)
  if (window.lucide) window.lucide.createIcons();
});
