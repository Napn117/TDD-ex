# MastersScholarship Unit Tests – TDD Sample

## 🧪 Overview

This project demonstrates **Test-Driven Development (TDD)** using the MSTest framework to verify the behavior of the `MastersScholarship` class. The tests focus on GPA-based scholarship assignment, internal state tracking, and object-level encapsulation.

---

## ✅ Key Features Tested

- **GPA-based Scholarship Awards**:
  - GPA ≥ 8: High GPA – maximum scholarship
  - GPA ≥ 7 and < 8: Medium GPA – partial scholarship
  - GPA < 7: Low GPA – review required

- **Assessment Count Tracking**:
  - A static counter tracks how many students have been assessed
  - A reset method clears the counter

- **Encapsulation Check**:
  - Confirms that scholarship values are specific to each instance
  - Verifies that one object’s scholarship values do not affect another

---

## 🔬 Test Coverage

- Scholarship messages are accurate based on GPA tiers
- Assessment counter increments correctly across multiple objects
- `ResetAssessmentCount()` correctly sets count back to zero
- Private-set properties do not carry over between different instances

---

## 📌 Notes

- All tests use `Assert.IsTrue` or `Assert.AreEqual` to verify correctness
- Tests are named to clearly express intent and expected behavior
- Designed for educational purposes to demonstrate clean unit testing and TDD practices

---

## 🚀 How to Run

1. Open the project in Visual Studio
2. Build the solution
3. Open the **Test Explorer**
4. Click **Run All Tests**
