const overlay = document.getElementById("overlay");
const formPopup = document.getElementById("contractForm");

// Mở form thêm hợp đồng
function openForm() {
    overlay.style.display = "block";
    formPopup.style.display = "block";
}

// Đóng form
function closeForm() {
    overlay.style.display = "none";
    formPopup.style.display = "none";
}

// Lọc theo trạng thái hợp đồng
document.getElementById("filterStatus").addEventListener("change", function() {
    let filter = this.value;
    let rows = document.querySelectorAll("#contractTable tr");
    rows.forEach(row => {
        let status = row.cells[5].innerText;
        row.style.display = (filter === "" || status === filter) ? "" : "none";
    });
});

// Tìm kiếm hợp đồng theo tên hoặc mã
document.getElementById("searchInput").addEventListener("keyup", function() {
    let keyword = this.value.toLowerCase();
    let rows = document.querySelectorAll("#contractTable tr");
    rows.forEach(row => {
        let text = row.innerText.toLowerCase();
        row.style.display = text.includes(keyword) ? "" : "none";
    });
});
