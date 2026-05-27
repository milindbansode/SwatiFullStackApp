namespace SwatiFullStackApp.Api.Catalog;

public interface ICatalogService
{
    CatalogResponse GetLearningCatalog();
    CatalogResponse GetAzureCatalog();
    CatalogResponse GetDesignPatternsCatalog();
}

public sealed class CatalogService : ICatalogService
{
    public CatalogResponse GetLearningCatalog() => new(
        "11+ Year Full-Stack Developer Roadmap",
        "A practical learning map that shows what senior engineers build every day across backend, frontend, data, DevOps, testing, and leadership.",
        [
            new CatalogSection(
                "architecture",
                "Architecture & Delivery",
                "Senior engineers choose trade-offs, not just frameworks. These topics help you shape systems that can grow safely.",
                [
                    new ConceptCard(
                        "Solution architecture",
                        "Break a large problem into APIs, UI modules, data stores, and deployment units that teams can own clearly.",
                        "Design a customer order flow with a web app, API, database, cache, and notification worker.",
                        "Explain why you picked a modular monolith or microservices instead of copying trends.",
                        ["Layered design", "Trade-off analysis", "Scalability"]),
                    new ConceptCard(
                        "REST API design",
                        "Good APIs use clear resources, versioning, validation, and status codes so frontend and mobile teams can move faster.",
                        "Create endpoints for products, carts, and orders with filtering, paging, validation, and problem details.",
                        "Focus on backward compatibility and operational simplicity.",
                        ["HTTP verbs", "Versioning", "Validation"]),
                    new ConceptCard(
                        "Agile delivery & backlog slicing",
                        "Large features succeed when broken into small vertical slices that can be built, tested, and reviewed fast.",
                        "Split a payment feature into API contract, UI workflow, audit logging, retries, and monitoring stories.",
                        "Use technical risk to decide sprint order, not just UI order.",
                        ["Story slicing", "Definition of done", "Release planning"])
                ]),
            new CatalogSection(
                "backend",
                "Backend, Data & Integration",
                "Modern backend work is about correctness, performance, and safe integration with other systems.",
                [
                    new ConceptCard(
                        ".NET Web API & dependency injection",
                        "ASP.NET Core gives you middleware, controllers, DI, configuration, and logging to build maintainable services.",
                        "Register a catalog service once and reuse it from controllers, background jobs, and tests.",
                        "Prefer small services with obvious responsibilities and easy constructor injection.",
                        ["Controllers", "DI", "Configuration"]),
                    new ConceptCard(
                        "Database design & EF Core",
                        "A strong full-stack engineer understands schema design, indexing, transactions, and ORM limits.",
                        "Model order headers and order lines, add indexes for search, and use transactions for checkout.",
                        "Know when to drop to SQL for reporting or bulk updates.",
                        ["Normalization", "Indexing", "Transactions"]),
                    new ConceptCard(
                        "Caching, queues & background processing",
                        "Not every task should happen during the web request. Use cache and async workers to keep apps responsive.",
                        "Cache dashboard counts for 5 minutes and send email invoices through a queue-backed worker.",
                        "Design for retries, idempotency, and visible failure handling.",
                        ["Redis", "Background jobs", "Idempotency"])
                ]),
            new CatalogSection(
                "frontend",
                "Angular Frontend Engineering",
                "Senior frontend work is more than screens. It includes state flow, user experience, maintainability, and performance.",
                [
                    new ConceptCard(
                        "Component architecture",
                        "Angular components should be small, reusable, and easy to test with a clear input and output story.",
                        "Create reusable cards, filters, and details panels instead of mixing all markup in one file.",
                        "Separate container components from presentational components when complexity grows.",
                        ["Standalone components", "Routing", "Reusability"]),
                    new ConceptCard(
                        "Forms, validation & UX",
                        "Good forms prevent bad data and explain errors quickly so users can finish work without support tickets.",
                        "Build a registration form with required fields, password rules, async email checks, and clear error messages.",
                        "Measure drop-off and improve wording, not just validation logic.",
                        ["Reactive forms", "Validation", "Accessibility"]),
                    new ConceptCard(
                        "Performance & browser debugging",
                        "UI performance depends on payload size, render cost, caching, and unnecessary change detection.",
                        "Use route-level lazy loading, track-by strategies, and network panel checks to keep pages fast.",
                        "Treat Core Web Vitals and real-user monitoring as product quality signals.",
                        ["Lazy loading", "Profiling", "Optimization"])
                ]),
            new CatalogSection(
                "quality",
                "Security, Testing & Operations",
                "Senior developers protect systems and make them easy to support after release.",
                [
                    new ConceptCard(
                        "Authentication & authorization",
                        "Identity proves who the user is. Authorization decides what the user is allowed to do.",
                        "Secure admin-only order actions with JWT claims and role-based policies.",
                        "Always think about least privilege, token expiry, and audit trails.",
                        ["JWT", "Policies", "Least privilege"]),
                    new ConceptCard(
                        "Testing pyramid",
                        "Reliable systems use unit tests for logic, integration tests for wiring, and UI tests for critical journeys.",
                        "Test the catalog service with xUnit and the Angular shell with headless browser tests.",
                        "Aim for business confidence instead of chasing test-count vanity metrics.",
                        ["Unit tests", "Integration tests", "UI tests"]),
                    new ConceptCard(
                        "Observability & CI/CD",
                        "Logs, metrics, traces, and pipelines let teams detect problems quickly and release changes safely.",
                        "Publish every merge through a pipeline that runs build, tests, security checks, and environment deployment.",
                        "Improve mean time to recovery, not only deployment speed.",
                        ["Logging", "Metrics", "Pipelines"])
                ])
        ],
        [
            "Build a modular e-commerce system with cart, payment, inventory, and reporting.",
            "Create a support portal with role-based access, audit history, and dashboards.",
            "Deliver the same product through dev, test, and production using CI/CD and infrastructure automation."
        ]);

    public CatalogResponse GetAzureCatalog() => new(
        "Azure Concepts Folder",
        "Use these cloud building blocks when you want secure, scalable, and observable enterprise delivery on Azure.",
        [
            new CatalogSection(
                "hosting",
                "Hosting & Compute",
                "Choose the right compute option based on control, cost, scale, and operations effort.",
                [
                    new ConceptCard(
                        "Azure App Service",
                        "A managed hosting service for web apps and APIs that removes most server maintenance work.",
                        "Deploy your ASP.NET Core API with staging slots and swap after smoke tests pass.",
                        "Great for fast business apps where platform simplicity matters more than low-level container tuning.",
                        ["Web hosting", "Deployment slots", "Autoscale"]),
                    new ConceptCard(
                        "Azure Functions",
                        "Serverless functions run event-driven code and charge mostly for usage instead of idle capacity.",
                        "Process uploaded files or queue messages without keeping a full web server alive.",
                        "Use for small, focused units of work with clear triggers and retry policies.",
                        ["Serverless", "Triggers", "Consumption model"]),
                    new ConceptCard(
                        "Azure Container Apps / AKS",
                        "Containers help when you need portability, background workers, or advanced scaling behavior.",
                        "Run API, worker, and scheduled jobs with environment-specific settings and health probes.",
                        "Pick AKS only when the team can own Kubernetes operations responsibly.",
                        ["Containers", "Scaling", "Health checks"])
                ]),
            new CatalogSection(
                "platform-data",
                "Data, Messaging & Integration",
                "Cloud-native systems become stronger when stateful services and async messaging are chosen intentionally.",
                [
                    new ConceptCard(
                        "Azure SQL Database",
                        "A managed relational database that gives backups, patching, scaling, and familiar SQL capabilities.",
                        "Store transactional business data such as customers, orders, invoices, and permissions.",
                        "Tune indexes and query plans before scaling up expensive tiers.",
                        ["Managed SQL", "Backups", "Index tuning"]),
                    new ConceptCard(
                        "Azure Storage",
                        "Blob, Queue, Table, and File storage cover common object and lightweight messaging needs.",
                        "Save exports, screenshots, invoices, and import files in Blob Storage with lifecycle rules.",
                        "Design naming conventions and retention policies from day one.",
                        ["Blob storage", "Lifecycle rules", "Cost control"]),
                    new ConceptCard(
                        "Azure Service Bus",
                        "A durable messaging service for decoupling services and processing work asynchronously.",
                        "Place order-completed events on a queue so invoicing and notification services can process independently.",
                        "Plan dead-letter handling and message contracts early.",
                        ["Queues", "Topics", "Dead-letter handling"])
                ]),
            new CatalogSection(
                "security-ops",
                "Security, Monitoring & Delivery",
                "Production cloud systems must be secured and observable before traffic arrives.",
                [
                    new ConceptCard(
                        "Azure Key Vault",
                        "Store secrets, certificates, and keys outside application code and configuration files.",
                        "Read connection strings and signing certificates securely during deployment and runtime.",
                        "Prefer managed identity over shared secrets whenever possible.",
                        ["Secrets", "Certificates", "Managed identity"]),
                    new ConceptCard(
                        "Application Insights",
                        "Collect request telemetry, exceptions, logs, and performance trends in one place.",
                        "Track slow APIs, failed dependencies, and user-impacting spikes after every release.",
                        "Use dashboards and alerts tied to service-level objectives.",
                        ["Telemetry", "Alerts", "Distributed tracing"]),
                    new ConceptCard(
                        "Azure DevOps / GitHub Actions",
                        "CI/CD pipelines automate build, test, security scanning, artifact versioning, and deployment approvals.",
                        "Build once, test once, and promote the same artifact through environments.",
                        "Keep environment configuration outside the compiled app and make rollbacks routine.",
                        ["Pipelines", "Approvals", "Release governance"])
                ])
        ],
        [
            "Deploy the API to App Service with slot-based releases.",
            "Move screenshots and document exports into Blob Storage with lifecycle retention.",
            "Push asynchronous notifications through Service Bus and monitor them with Application Insights."
        ]);

    public CatalogResponse GetDesignPatternsCatalog() => new(
        "Design Patterns Folder",
        "Patterns are reusable problem-solving ideas. The goal is not to use all of them, but to recognize where each one reduces change risk.",
        [
            new CatalogSection(
                "creational",
                "Creational Patterns",
                "These patterns help you create objects cleanly when construction starts to vary.",
                [
                    new ConceptCard(
                        "Factory",
                        "A factory hides object creation rules so the calling code does not need to know every concrete type.",
                        "Choose a payment provider implementation based on environment or tenant settings.",
                        "Use factories when branching constructor logic starts leaking everywhere.",
                        ["Object creation", "Polymorphism", "Encapsulation"]),
                    new ConceptCard(
                        "Builder",
                        "A builder assembles complex objects step by step and keeps construction readable.",
                        "Create a reporting query or email payload with many optional sections.",
                        "Good when constructors become long and confusing.",
                        ["Stepwise construction", "Readability", "Optional configuration"])
                ]),
            new CatalogSection(
                "structural",
                "Structural Patterns",
                "These patterns shape how classes or services are connected.",
                [
                    new ConceptCard(
                        "Adapter",
                        "An adapter converts one interface into another so your core code stays stable while integrations vary.",
                        "Wrap a third-party shipping API in your own stable interface.",
                        "Always isolate vendor-specific details behind your adapter boundary.",
                        ["Integration isolation", "Stable contracts", "Replaceability"]),
                    new ConceptCard(
                        "Decorator",
                        "A decorator adds behavior around an existing service without changing its core implementation.",
                        "Add caching or logging around a report service by wrapping it in another class.",
                        "Use decorators for cross-cutting concerns that should stay composable.",
                        ["Cross-cutting concerns", "Composition", "Extensibility"])
                ]),
            new CatalogSection(
                "behavioral",
                "Behavioral Patterns",
                "Behavioral patterns help coordinate logic and decision flow cleanly.",
                [
                    new ConceptCard(
                        "Strategy",
                        "A strategy lets you swap algorithms without changing the calling code.",
                        "Choose tax calculation logic based on country or product type.",
                        "A good fit when if/else chains keep growing with business rules.",
                        ["Algorithm switching", "Open/closed principle", "Testability"]),
                    new ConceptCard(
                        "Observer / publish-subscribe",
                        "Observers react when something important happens without the source needing direct knowledge of listeners.",
                        "Raise an order placed event that updates analytics, notifications, and audit logs.",
                        "Prefer explicit event contracts so changes stay manageable.",
                        ["Events", "Loose coupling", "Async workflows"])
                ]),
            new CatalogSection(
                "enterprise",
                "Enterprise Application Patterns",
                "These are common patterns that appear in large business systems.",
                [
                    new ConceptCard(
                        "Repository",
                        "A repository abstracts data access so domain logic does not depend on query details everywhere.",
                        "Expose an order repository to fetch aggregates while hiding EF Core query setup.",
                        "Do not over-abstract trivial CRUD; use it where it improves domain clarity.",
                        ["Data abstraction", "Domain focus", "Test seams"]),
                    new ConceptCard(
                        "CQRS",
                        "Command Query Responsibility Segregation separates write operations from read models when needs differ.",
                        "Use simple writes for order updates but specialized read models for dashboard reporting.",
                        "Apply only where complexity pays back in clarity or scale.",
                        ["Read/write separation", "Scalability", "Task-based design"]),
                    new ConceptCard(
                        "Mediator",
                        "A mediator routes requests to handlers so controllers stay thin and application logic stays organized.",
                        "Send a CreateOrder command from the API and handle validation, persistence, and events in one request pipeline.",
                        "Helpful in large codebases when use cases outgrow fat services.",
                        ["Request handling", "Separation of concerns", "Pipeline behavior"])
                ])
        ],
        [
            "Wrap third-party providers with adapters before the first production integration.",
            "Use decorators for caching and logging instead of repeating cross-cutting code.",
            "Adopt CQRS selectively for complex read models, not for every table."
        ]);
}
