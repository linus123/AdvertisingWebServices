describe("Customer Service Tests", function () {

    describe("GetAll", function () {
        var customerData;
        
        beforeEach(function (done) {

            var populateCustomerData = function() {

                if (!customerData) {

                    $.get("/Customer/GetAll", function(data) {
                        customerData = data;
                        console.log(data);
                        done();
                    });

                } else {
                    done();
                }

            };
            
            setTimeout(populateCustomerData, 1);
        });

        it("should return some data", function (done) {
            
            expect(customerData).toBeDefined();

            done();
        });

        it("should return at least ten records", function (done) {

            expect(customerData.length).toBeGreaterThan(10);

            done();
        });

        it("should return CustomerId for all customers", function (done) {
            
            forEachCustomer(function(customer) {
                expect(customer.CustomerId).toBeDefined();
            });

            done();
        });

        it("should return Name for all customers", function (done) {
            
            forEachCustomer(function (customer) {
                expect(customer.Name).toBeDefined();
            });

            done();
        });

        var forEachCustomer = function (customerOperation) {
            $.each(customerData, function (index, customer) {

                customerOperation(customer);

            });
        };
    });

    describe("GetDetail", function() {
        var singleCustomer;

        beforeEach(function(done) {

            var populateSingleCustomer = function() {

                if (!singleCustomer) {

                    var settings = {
                        customerId: 1
                    };

                    $.get("/Customer/GetDetail", settings, function(data) {
                        singleCustomer = data;
                        console.log(data);
                        done();
                    });

                } else {
                    done();
                }

            };

            setTimeout(populateSingleCustomer, 1);
        });

        it("should return customer", function(done) {

            expect(singleCustomer).toBeDefined();

            done();
        });

        it("should return CustomerId", function(done) {

            expect(singleCustomer.CustomerId).toBeDefined();

            done();
        });

        it("should return Company", function (done) {

            expect(singleCustomer.Company).toBeDefined();

            done();
        });

        it("should return LastName", function (done) {

            expect(singleCustomer.LastName).toBeDefined();

            done();
        });

        it("should return FirstName", function (done) {

            expect(singleCustomer.FirstName).toBeDefined();

            done();
        });

        it("should return JobTitle", function (done) {

            expect(singleCustomer.JobTitle).toBeDefined();

            done();
        });

        it("should return Address", function (done) {

            expect(singleCustomer.Address).toBeDefined();

            done();
        });

        it("should return City", function (done) {

            expect(singleCustomer.City).toBeDefined();

            done();
        });

        it("should return State", function (done) {

            expect(singleCustomer.State).toBeDefined();

            done();
        });

    });

});