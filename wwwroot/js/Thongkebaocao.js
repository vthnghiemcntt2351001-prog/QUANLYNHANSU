document.addEventListener("DOMContentLoaded", () => {
  showLoading();
  setTimeout(() => {
    loadStats();
    initCharts();
    loadTable();
    loadActivities();
    hideLoading();
  }, 1000);

  document.getElementById("refreshBtn").addEventListener("click", () => {
    showLoading();
    setTimeout(() => {
      loadStats();
      hideLoading();
    }, 800);
  });
});

function showLoading() {
  document.getElementById("loadingOverlay").classList.add("active");
}
function hideLoading() {
  document.getElementById("loadingOverlay").classList.remove("active");
}

// ====== THỐNG KÊ ======
function loadStats() {
  animateValue("totalEmployees", 0, 125, 1500);
  animateValue("newEmployees", 0, 8, 1500);
  animateValue("departments", 0, 6, 1500);
  animateValue("resignRate", 0, 4.2, 1500, "%");
}

function animateValue(id, start, end, duration, suffix = "") {
  const obj = document.getElementById(id);
  let startTimestamp = null;
  const step = (timestamp) => {
    if (!startTimestamp) startTimestamp = timestamp;
    const progress = Math.min((timestamp - startTimestamp) / duration, 1);
    obj.textContent = Math.floor(progress * (end - start) + start) + suffix;
    if (progress < 1) window.requestAnimationFrame(step);
  };
  window.requestAnimationFrame(step);
}

// ====== BIỂU ĐỒ ======
function initCharts() {
  const growthCtx = document.getElementById("growthChart");
  new Chart(growthCtx, {
    type: "line",
    data: {
      labels: ["T1", "T2", "T3", "T4", "T5", "T6", "T7", "T8", "T9", "T10"],
      datasets: [
        {
          label: "Tổng nhân viên",
          data: [100, 105, 110, 115, 118, 120, 122, 124, 125, 125],
          borderColor: "#4f46e5",
          backgroundColor: "rgba(99,102,241,0.1)",
          fill: true,
          tension: 0.4,
        },
      ],
    },
  });

  const deptCtx = document.getElementById("departmentChart");
  new Chart(deptCtx, {
    type: "doughnut",
    data: {
      labels: ["Kỹ Thuật", "Kinh Doanh", "Marketing", "Nhân Sự", "Kế Toán"],
      datasets: [
        {
          data: [40, 25, 15, 10, 10],
          backgroundColor: ["#6366f1", "#10b981", "#f59e0b", "#8b5cf6", "#ef4444"],
        },
      ],
    },
    options: { cutout: "70%" },
  });

  const statusCtx = document.getElementById("statusChart");
  new Chart(statusCtx, {
    type: "pie",
    data: {
      labels: ["Đang Làm Việc", "Nghỉ Phép", "Thử Việc", "Đã Nghỉ"],
      datasets: [
        {
          data: [80, 10, 7, 3],
          backgroundColor: ["#10b981", "#3b82f6", "#f59e0b", "#ef4444"],
        },
      ],
    },
  });
}

// ====== BẢNG NHÂN SỰ ======
function loadTable() {
  const employees = [
    { id: "NV001", name: "Nguyễn Văn An", dept: "Kỹ Thuật", pos: "Lập Trình Viên", date: "10/01/2024", status: "Đang Làm Việc" },
    { id: "NV002", name: "Trần Thị Bình", dept: "Marketing", pos: "Chuyên Viên", date: "15/02/2024", status: "Đang Làm Việc" },
    { id: "NV003", name: "Lê Hồng Cường", dept: "Kế Toán", pos: "Kế Toán Viên", date: "20/03/2024", status: "Nghỉ Phép" },
    { id: "NV004", name: "Phạm Thu Dung", dept: "Kinh Doanh", pos: "Trưởng Phòng", date: "01/05/2024", status: "Đang Làm Việc" },
    { id: "NV005", name: "Hoàng Văn Em", dept: "Nhân Sự", pos: "HR", date: "05/06/2024", status: "Thử Việc" },
  ];

  const tbody = document.getElementById("employeeTable");
  tbody.innerHTML = "";
  employees.forEach((e) => {
    const tr = document.createElement("tr");
    tr.innerHTML = `
      <td>${e.id}</td>
      <td>${e.name}</td>
      <td>${e.dept}</td>
      <td>${e.pos}</td>
      <td>${e.date}</td>
      <td>${e.status}</td>
    `;
    tbody.appendChild(tr);
  });
}

// ====== HOẠT ĐỘNG GẦN ĐÂY ======
function loadActivities() {
  const activities = [
    { icon: "fa-user-plus", color: "#10b981", text: "Nhân viên mới: Nguyễn Văn An", time: "5 phút trước" },
    { icon: "fa-briefcase", color: "#6366f1", text: "Thăng chức cho Trần Thị Bình", time: "1 giờ trước" },
    { icon: "fa-clock", color: "#f59e0b", text: "Lê Hồng Cường đăng ký nghỉ phép", time: "2 giờ trước" },
    { icon: "fa-users", color: "#3b82f6", text: "Cuộc họp định kỳ phòng Kinh Doanh", time: "3 giờ trước" },
  ];

  const feed = document.getElementById("activityFeed");
  feed.innerHTML = "";
  activities.forEach((a) => {
    const div = document.createElement("div");
    div.className = "activity-item";
    div.innerHTML = `
      <div class="activity-icon" style="background:${a.color}20;color:${a.color}">
        <i class="fas ${a.icon}"></i>
      </div>
      <div>
        <p>${a.text}</p>
        <span class="activity-time">${a.time}</span>
      </div>
    `;
    feed.appendChild(div);
  });
}
