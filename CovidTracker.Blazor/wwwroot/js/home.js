const ctx = document.getElementById('myChart');

const months = [
  'January', 'February', 'March', 'April', 'May', 'June', 'July', 'August', 'September', 'October', 'November', 'December'
];

const randomSickDays = Array.from({length: 12}, () => Math.floor(Math.random() * 10) + 1);

new Chart(ctx, {
  type: 'bar',
  data: {
    labels: months,
    datasets: [{
      label: '# of Sick Days',
      data: randomSickDays,
      borderWidth: 1
    }]
  },
  options: {
    scales: {
      y: {
        beginAtZero: true
      }
    }
  }
});
