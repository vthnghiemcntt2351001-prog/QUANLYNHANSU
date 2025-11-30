
let currentRole = 'employee';

function selectRole(role) {
    currentRole = role;
    document.getElementById("roleInput").value = role;

    const options = document.querySelectorAll('.role-option');
    options.forEach(option => option.classList.remove('active'));

    if (role === 'employee') {
        options[0].classList.add('active');

        document.getElementById('usernameLabel').textContent =
            'Tên đăng nhập nhân viên';

        document.getElementById('loginButtonText').textContent =
            'Đăng nhập với tư cách nhân viên';

    } else {
        options[1].classList.add('active');

        document.getElementById('usernameLabel').textContent =
            'Tên đăng nhập Admin / Nhân sự';

        document.getElementById('loginButtonText').textContent =
            'Đăng nhập với tư cách Quản lý';
    }
}

setTimeout(() => {
    const alertBox = document.querySelector('.login-error');
    if (alertBox) {
        alertBox.classList.add('hide');
    }
}, 2000); // sau 2 giây sẽ ẩn