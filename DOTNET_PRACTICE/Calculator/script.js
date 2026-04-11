const firstNumberInput = document.getElementById("first-number");
const secondNumberInput = document.getElementById("second-number");
const resultText = document.getElementById("result-text");
const message = document.getElementById("message");
const operationButtons = document.querySelectorAll("[data-operation]");

const operationSymbols = {
  add: "+",
  subtract: "-",
  multiply: "x",
  divide: "÷",
};

function formatNumber(value) {
  const rounded = Number.isInteger(value) ? value : Number(value.toFixed(2));
  return rounded.toLocaleString("en-IN", { maximumFractionDigits: 2 });
}

function readInputs() {
  const firstValue = firstNumberInput.value.trim();
  const secondValue = secondNumberInput.value.trim();

  if (!firstValue || !secondValue) {
    throw new Error("Please enter both numbers before choosing an operation.");
  }

  const firstNumber = Number(firstValue);
  const secondNumber = Number(secondValue);

  if (Number.isNaN(firstNumber) || Number.isNaN(secondNumber)) {
    throw new Error("Both fields must contain valid numeric values.");
  }

  return { firstNumber, secondNumber };
}

function calculate(operation, firstNumber, secondNumber) {
  switch (operation) {
    case "add":
      return firstNumber + secondNumber;
    case "subtract":
      return firstNumber - secondNumber;
    case "multiply":
      return firstNumber * secondNumber;
    case "divide":
      if (secondNumber === 0) {
        throw new Error("Division by zero is not allowed.");
      }
      return firstNumber / secondNumber;
    default:
      throw new Error("Unsupported operation selected.");
  }
}

function updateResult(operation) {
  try {
    const { firstNumber, secondNumber } = readInputs();
    const result = calculate(operation, firstNumber, secondNumber);
    const symbol = operationSymbols[operation];

    message.textContent = "";
    resultText.textContent = `${formatNumber(firstNumber)} ${symbol} ${formatNumber(secondNumber)} = ${formatNumber(result)}`;
  } catch (error) {
    message.textContent = error.message;
    resultText.textContent = "Enter two numbers and choose an operation.";
  }
}

operationButtons.forEach((button) => {
  button.addEventListener("click", () => {
    updateResult(button.dataset.operation);
  });
});
