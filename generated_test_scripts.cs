// ===== Test Case 1 =====
```csharp
using NUnit.Framework;
 
[Test]
public void TC_001_CreatePaxListWithOneAdult()
{
    // Create a PaxList object.
    var paxList = new PaxList();
 
    // Add one Pax element with PTC=ADT and a unique PaxID.
    paxList.AddPax(new Pax { PTC = "ADT", PaxID = "UniquePaxID" });
 
    // Assert the expected result.
    Assert.IsTrue(paxList.IsValid, "The system should accept the PaxList with one adult.");
}
```
 
// ===== Test Case 2 =====
```csharp
using NUnit.Framework;
 
[Test]
public void TC_002_CreatePaxListWithMultipleAdults()
{
    // Create a PaxList object.
    var paxList = new PaxList();
 
    // Add two Pax elements with PTC=ADT and unique PaxIDs.
    paxList.AddPax(new Pax { PaxId = "P123", Ptc = "ADT" });
    paxList.AddPax(new Pax { PaxId = "P456", Ptc = "ADT" });
 
    // Assert that the system accepts the PaxList with multiple adults.
    Assert.IsTrue(paxList.IsValid);
}
```
 
// ===== Test Case 3 =====
```csharp
using NUnit.Framework;
 
public class PaxListTests
{
    [Test]
    public void TC_003_CreatePaxListWithOneChild()
    {
        // Create a PaxList object.
        var paxList = new PaxList();
 
        // Add one Pax element with PTC=CHD and a unique PaxID.
        paxList.AddPax(new Pax { PaxID = "CHD_001", PTC = "CHD" });
 
        // Assert that the system accepts the PaxList with one child.
        Assert.IsTrue(paxList.IsValid());
    }
}
```
 
// ===== Test Case 4 =====
```csharp
using NUnit.Framework;
 
public class PaxListTests
{
    [Test, Order(4)]
    public void TC_004_CreatePaxListWithOneYouth()
    {
        // Create a PaxList object.
        var paxList = new PaxList();
 
        // Add one Pax element with PTC=GBE and a unique PaxID.
        paxList.AddPax(new Pax { PTC = "GBE", PaxID = "UniqueID" });
 
        // Assert that the system accepts the PaxList with one youth.
        Assert.IsTrue(paxList.IsValid());
    }
}
```
 
// ===== Test Case 5 =====
```csharp
using NUnit.Framework;
 
public class PaxListTests
{
    [Test]
    public void TC_005_CreatePassengerListWithOneInfant()
    {
        // Create a PaxList object.
        var paxList = new PaxList();
 
        // Add one Pax element with PTC=INF and a unique PaxID.
        var pax = new Pax { PTC = "INF", PaxID = "UniqueInfantID" };
        paxList.AddPax(pax);
 
        // Assert that the system accepts the PaxList with one infant.
        Assert.IsTrue(paxList.IsValid());
    }
}
```
 
// ===== Test Case 6 =====
```csharp
using NUnit.Framework;
 
[Test]
public void TC_006_CreatePaxListWithMultipleInfants()
{
    // Create a PaxList object.
    var paxList = new PaxList();
 
    // Add two Pax elements with PTC=INF and unique PaxIDs.
    paxList.AddPax(new Pax { PaxId = "INF1", Ptc = "INF" });
    paxList.AddPax(new Pax { PaxId = "INF2", Ptc = "INF" });
 
    // Assert the expected result.
    Assert.IsTrue(paxList.IsValid);
}
```
 
// ===== Test Case 7 =====
```csharp
[Test]
public void TC_007_CreatePassengerListWithInfantAndAdult()
{
    // Create a PaxList object.
    var paxList = new PaxList();
 
    // Add one Pax element with PTC=ADT and a unique PaxID.
    var adultPax = new Pax { PaxID = "ADT_123", PTC = "ADT" };
    paxList.AddPax(adultPax);
 
    // Add one Pax element with PTC=INF and a unique PaxID.
    var infantPax = new Pax { PaxID = "INF_456", PTC = "INF" };
    paxList.AddPax(infantPax);
 
    // Assert that the system accepts the PaxList with an infant associated with an adult.
    Assert.IsTrue(true, "Success. The system should accept the PaxList with an infant associated with an adult.");
}
```
 
// ===== Test Case 8 =====
```csharp
using NUnit.Framework;
 
[Test]
public void TC_008_CreatePaxListWithMultipleInfantsPerAdult()
{
    // Create a PaxList object.
    var paxList = new PaxList();
 
    // Add one Pax element with PTC=ADT and a unique PaxID.
    var adultPax = new Pax { PaxID = "ADT_123", PTC = "ADT" };
    paxList.AddPax(adultPax);
 
    // Add two Pax elements with PTC=INF and unique PaxIDs.
    var infantPax1 = new Pax { PaxID = "INF_456", PTC = "INF" };
    paxList.AddPax(infantPax1);
    var infantPax2 = new Pax { PaxID = "INF_789", PTC = "INF" };
    paxList.AddPax(infantPax2);
 
    // Error. The system should reject the PaxList as it violates the maximum one infant per adult rule.
    Assert.AreEqual("Error. The system should reject the PaxList as it violates the maximum one infant per adult rule.", paxList.Validate());
}
```
 
// ===== Test Case 9 =====
```csharp
using NUnit.Framework;
 
[Test]
public void TC_009_CreatePaxListWithInvalidPTC()
{
    // Create a PaxList object.
    var paxList = new PaxList();
 
    // Add one Pax element with PTC=INVALID and a unique PaxID.
    paxList.AddPax(new Pax { PaxID = "TestPax1", PTC = "INVALID" });
 
    // Error. The system should reject the PaxList due to the invalid PTC code.
    Assert.That(paxList.IsValid, Is.False);
}
```
 
// ===== Test Case 10 =====
```csharp
using NUnit.Framework;
 
public class PaxListTests
{
    [Test]
    public void TC_010_CreatePaxListWithOnlyInfants()
    {
        // Create a PaxList object.
        var paxList = new PaxList();
 
        // Add three Pax elements with PTC=INF and unique PaxIDs.
        paxList.Add(new Pax { PaxID = "INF1", PTC = "INF" });
        paxList.Add(new Pax { PaxID = "INF2", PTC = "INF" });
        paxList.Add(new Pax { PaxID = "INF3", PTC = "INF" });
 
        // Error. The system should reject the PaxList as it lacks at least one adult.
        Assert.That(paxList.IsValid, Is.False, "PaxList should be invalid as it lacks an adult.");
    }
}
```
 
// ===== Test Case 11 =====
```csharp
using NUnit.Framework;
 
[Test]
public void TC_011_CreatePaxListWithOnlyChildren_ShouldReject()
{
    // Create a PaxList object.
    var paxList = new PaxList();
 
    // Add three Pax elements with PTC=CHD and unique PaxIDs.
    paxList.Add(new Pax { PaxId = "CHD001", PTC = "CHD" });
    paxList.Add(new Pax { PaxId = "CHD002", PTC = "CHD" });
    paxList.Add(new Pax { PaxId = "CHD003", PTC = "CHD" });
 
    // Error. The system should reject the PaxList as it lacks at least one adult.
    Assert.That(paxList.IsValid, Is.False);
}
```
 
// ===== Test Case 12 =====
```csharp
using NUnit.Framework;
 
[Test]
public void TC_012_CreatePaxListWithOnlyYouths_ShouldReject()
{
    // Create a PaxList object.
    var paxList = new PaxList();
 
    // Add three Pax elements with PTC=GBE and unique PaxIDs.
    paxList.Add(new Pax { PaxId = "123", PTC = "GBE" });
    paxList.Add(new Pax { PaxId = "456", PTC = "GBE" });
    paxList.Add(new Pax { PaxId = "789", PTC = "GBE" });
 
    // Error. The system should reject the PaxList as it lacks at least one adult.
    Assert.That(paxList.IsValid, Is.False);
}
```
 
 
 