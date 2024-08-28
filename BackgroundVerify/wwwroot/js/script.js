document.getElementById('verificationForm').addEventListener('submit', async function (e) {
    e.preventDefault();
    console.log("XYZ");
    const employeeId = document.getElementById('employeeId').value;
    const companyName = document.getElementById('companyName').value;
    const verificationCode = document.getElementById('verificationCode').value;
    const resultElement = document.getElementById('result');

    try {
        
        const response = await fetch('https://localhost:7012/api/EmploymentVerification/verify-employment', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({
                employeeId: parseInt(employeeId),
                companyName: companyName,
                verificationCode: verificationCode
            })
        });

        const data = await response.json();
        resultElement.textContent = data.verified ? 'Verified' : 'Not Verified';
        resultElement.classList.remove('text-bg-danger', 'text-bg-success');
        if (resultElement.textContent == 'Not Verified') {
            resultElement.classList.add('text-bg-danger');
        } else {
            resultElement.classList.add('text-bg-success');
        }
    } catch (error) {
        resultElement.textContent = 'Error verifying employment';
    }
});