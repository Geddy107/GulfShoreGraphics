# Project Step 4

## Requirements
```
Describe each of your high-level requirements using multiple detailed requirements. You may use the "formal requirement syntax" provided in a separate link, the "Gherkin" language, or user stories as your specification language. Each requirements should be given a number or other unique identifier for traceability and be arranged under a heading which references the high-level requirement it describes.

Categorize each of your requirements as functional (something the system must do) or non-functional (something the system must be, or a standard the system must meet) and arrange them accordingly under subheadings.

Your requirements document should be included in your project source repository, preferably in a "docs/" subdirectory under the top level.

Be prepared to present and explain your project with high-level requirements in class next week.
```
<b><span style ="color: red">Gherkin Language</span></b>
```
Feature:
Given:
When:
Then: 
```


MVP_________________________________________________________

<b><span style ="color: orange"> 1. Main tabs will include: Home, Products, Services, Gallery, About </span></b>
```
1. Feature: Hello World
Given: The website needs to be created.
When: The user types the correct domain name.
Then: The user will be directed to the main page for the graphics business.
```
```
2. Feature: Products, Services, Gallery, About tabs
Given:The user is navigating the site.
When: When the user clicks on any hyper tab name listed above.
Then: The user will be directed to that tabs corresponding page.
```
```
3. Feature: Tab Page's Data, Images, ect.
Given: The user navigates to any hyper tab
When: Once the page is entered.
Then: The User will be greeted witht the applicable information that they navigated to that tab for.
```
```
4. Feature: Contact info, and other business related information
Given: the customer requires more information, specifically about the buisiness.
When: the customer scrolls to the bottom of any tabs page
Then: the custome will see the "business info block" containing all info about the organization (contact info, about, where materials are sourced, ect.).
```

<b><span style ="color: orange"> 2. Allow customers to see decals/prices that are currently in-stock and can be shipped or picked up immediately (salt life stickers and products that are always on hand.) </span></b>
```
1. Feature: Products Consolidated 
Given: The user wants to make a purchase.
When: The user navigates to the products tab.
Then: The user will see all products and services populate on the page.
```
```
2. Feature: Product Prices and Images
Given: The user whats to know what the product is and how much it costs 
When: The user is on the Products Page 
Then: They will see images of the products along with the price for that item.

```
```
3. Feature: Object Distcription 
Given: The user needs more information on a product.
When: The user clicks on the product.
Then: The product description will open up and allow for buy options (if applicable) and the ability to add to a cart.
```

<b><span style ="color: orange">3. List services that are available and how much the services cost(such as vehicle wraps, business decals for vehicles ect.)</span></b>
```
Feature: Services tab
Given: should the user require services.
When: If the user clicks the Services Tab.
Then: the user will see all services that the company offers.
```
```
2. Feature: Service Prices and Images
Given: The user whats to know what the service is and how much it costs 
When: The user is on the Services Page 
Then: They will see images of the Services along with the general estimated price for that Service.
```
```
3. Feature: Object Distcription 
Given: The user needs more information on a Service.
When: The user clicks on the specific Service.
Then: The Service description will open up and allow for buy options and a contact phone number so the client can communicate their ideas with a representative.
```
<b><span style ="color: orange">4. A gallery of finished products.</span></b>
```
1. Feature: Images Consolidated 
Given: The user wants to view some of the work done by the business.
When: The user navigates to the gallery tab.
Then: The user will see all products and services images (in a more artistic format) populate on the page.
```
```
1. Feature: Image hyperlinks 
Given: If the user sees a product or service that they like in the gallery
When: The user hovers over the image.
Then: a hyperlink will allow the user to go immediatly to the product displayed.
```

<b><span style ="color: orange">5. Do not allow for the storing of credit card information. </span></b>
```
Feature: Dont allow users credit card numbers to be saved 
Given: the customer pays with a credit card 
When: they enter their credit card data
Then: the data is never saved or stored anywhere on the clients side to avoid any potential data breaches.
```


