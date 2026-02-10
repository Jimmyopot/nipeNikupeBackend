using Microsoft.EntityFrameworkCore;
using NipeNikupe.Models;

namespace NipeNikupe.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        
        public virtual DbSet<User> users { get; set; }
        public virtual DbSet<SignUp> SignUps { get; set; }
        public virtual DbSet<County> Counties { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<ChatMessage> ChatMessages { get; set; }
        public virtual DbSet<SkillExchangeSession> SkillExchangeSessions { get; set; }
        public virtual DbSet<SkillSearchLog> SkillSearchLogs { get; set; }
        public virtual DbSet<Rating> Ratings { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<User>().ToTable("users");
            builder.Entity<SignUp>().ToTable("signUps");
            builder.Entity<County>().ToTable("counties");
            builder.Entity<Skill>().ToTable("skills");
            builder.Entity<ChatMessage>().ToTable("chat_messages");
            builder.Entity<SkillExchangeSession>().ToTable("skill_exchange_sessions");
            builder.Entity<SkillSearchLog>().ToTable("skill_search_logs");
            builder.Entity<Rating>().ToTable("ratings");

            builder.Entity<County>().HasData(
               new County { Id = 1, Name = "Mombasa" },
               new County { Id = 2, Name = "Kwale" },
               new County { Id = 3, Name = "Kilifi" },
               new County { Id = 4, Name = "Tana River" },
               new County { Id = 5, Name = "Lamu" },
               new County { Id = 6, Name = "Taita-Taveta" },
               new County { Id = 7, Name = "Garissa" },
               new County { Id = 8, Name = "Wajir" },
               new County { Id = 9, Name = "Mandera" },
               new County { Id = 10, Name = "Marsabit" },
               new County { Id = 11, Name = "Isiolo" },
               new County { Id = 12, Name = "Meru" },
               new County { Id = 13, Name = "Tharaka-Nithi" },
               new County { Id = 14, Name = "Embu" },
               new County { Id = 15, Name = "Kitui" },
               new County { Id = 16, Name = "Machakos" },
               new County { Id = 17, Name = "Makueni" },
               new County { Id = 18, Name = "Nyandarua" },
               new County { Id = 19, Name = "Nyeri" },
               new County { Id = 20, Name = "Kirinyaga" },
               new County { Id = 21, Name = "Murang'a" },
               new County { Id = 22, Name = "Kiambu" },
               new County { Id = 23, Name = "Turkana" },
               new County { Id = 24, Name = "West Pokot" },
               new County { Id = 25, Name = "Samburu" },
               new County { Id = 26, Name = "Trans-Nzoia" },
               new County { Id = 27, Name = "Uasin Gishu" },
               new County { Id = 28, Name = "Elgeyo-Marakwet" },
               new County { Id = 29, Name = "Nandi" },
               new County { Id = 30, Name = "Baringo" },
               new County { Id = 31, Name = "Laikipia" },
               new County { Id = 32, Name = "Nakuru" },
               new County { Id = 33, Name = "Narok" },
               new County { Id = 34, Name = "Kajiado" },
               new County { Id = 35, Name = "Kericho" },
               new County { Id = 36, Name = "Bomet" },
               new County { Id = 37, Name = "Kakamega" },
               new County { Id = 38, Name = "Vihiga" },
               new County { Id = 39, Name = "Bungoma" },
               new County { Id = 40, Name = "Busia" },
               new County { Id = 41, Name = "Siaya" },
               new County { Id = 42, Name = "Kisumu" },
               new County { Id = 43, Name = "Homa Bay" },
               new County { Id = 44, Name = "Migori" },
               new County { Id = 45, Name = "Kisii" },
               new County { Id = 46, Name = "Nyamira" },
               new County { Id = 47, Name = "Nairobi" }
           );

            // Seed Skills data - Call helper method
            SeedSkills(builder);
        }

        private void SeedSkills(ModelBuilder builder)
        {
            var skills = new List<Skill>();
            int id = 1;

            // Professional & Business Skills
            AddSkills(ref id, "ProfessionalBusiness", new[]
            {
                "Accounting", "Auditing", "Tax preparation", "Financial analysis",
                "Budgeting", "Forecasting", "Strategic planning", "Project management",
                "Risk management", "Business writing", "Negotiation", "Presentation skills",
                "Public speaking", "Leadership", "Team management", "Conflict resolution",
                "Change management", "Time management", "Decision making", "Critical thinking",
                "Problem solving", "Data analysis", "Market research", "Sales techniques",
                "Customer service", "Supply chain management", "Procurement", "Contract management",
                "Stakeholder engagement", "Business development", "Networking", "Event planning",
                "Coaching", "Mentoring", "Performance appraisal", "Recruitment", "Onboarding",
                "Employee training", "Diversity & inclusion", "Corporate governance",
                "Ethics & compliance", "Financial modelling", "Mergers & acquisitions",
                "Due diligence", "Portfolio management", "Asset management", "Investment analysis",
                "Fundraising", "Grant writing", "Proposal development"
            }, skills);

            // Technical & IT Skills
            AddSkills(ref id, "TechnicalIT", new[]
            {
                "Microsoft Excel", "Microsoft PowerPoint", "Microsoft Word", "Microsoft Access",
                "Google Sheets", "Google Docs", "Frontend developer", "Backend developer",  "Python programming", "Java programming",
                "C++ programming", "SQL", "HTML", "CSS", "JavaScript", "React", "Angular",
                "Vue.js", "Node.js", "PHP", "Ruby", "Swift", "Kotlin", "R programming",
                "MATLAB", "Data visualization", "Machine learning", "Artificial intelligence",
                "Deep learning", "Natural language processing", "Computer vision",
                "Cloud computing", "AWS", "Azure", "Google Cloud Platform", "Cybersecurity",
                "Ethical hacking", "Network administration", "Database management",
                "Systems analysis", "Software testing", "QA automation", "Mobile app development",
                "Web development", "API integration", "DevOps", "CI/CD", "Docker", "Kubernetes",
                "Agile methodology", "Scrum", "Kanban", "IT support", "Troubleshooting",
                "Hardware repair", "Blockchain", "Solidity", "Smart contracts", "Robotics",
                "IoT", "Virtualization", "UX design", "UI design", "Figma", "Adobe XD",
                "Sketch", "Graphic design", "Adobe Photoshop", "Adobe Illustrator",
                "Video editing", "Adobe Premiere Pro", "Final Cut Pro", "Animation",
                "3D modelling", "Blender", "Maya", "CAD", "AutoCAD", "SolidWorks",
                "Game development", "Unity", "Unreal Engine", "AR/VR development",
                "Digital marketing", "SEO", "SEM", "Google Analytics", "Social media marketing"
            }, skills);

            // Creative & Artistic Skills
            AddSkills(ref id, "CreativeArtistic", new[]
            {
                "Drawing", "Painting", "Sculpting", "Photography", "Videography",
                "Film editing", "Storyboarding", "Creative writing", "Poetry", "Songwriting",
                "Music composition", "Playing piano", "Playing guitar", "Playing drums",
                "Singing", "Acting", "Dancing", "Choreography", "Fashion design",
                "Interior design", "Architecture", "Calligraphy", "Pottery", "Jewellery making",
                "Woodworking", "Origami", "Knitting", "Crocheting", "Embroidery", "Quilting",
                "Floral arrangement", "Baking", "Cake decorating", "Cooking", "Mixology",
                "Ice sculpting", "Magic tricks", "Stand-up comedy", "Podcasting", "Blogging",
                "Content creation", "Brand design", "Logo design", "Typography"
            }, skills);

            // Language & Communication Skills
            AddSkills(ref id, "LanguageCommunication", new[]
            {
                "English fluency", "French fluency", "Spanish fluency", "German fluency",
                "Italian fluency", "Portuguese fluency", "Russian fluency", "Mandarin fluency",
                "Japanese fluency", "Arabic fluency", "Hindi fluency", "Swahili fluency",
                "Sign language", "Translation", "Interpretation", "Copywriting", "Editing",
                "Proofreading", "Speech writing", "Debate", "Persuasion", "Interviewing",
                "Storytelling", "Non-verbal communication", "Active listening", "Empathy",
                "Mediation", "Rapport building", "Cross-cultural communication",
                "Technical writing", "Academic writing", "Business communication"
            }, skills);

            // Personal Development & Life Skills
            AddSkills(ref id, "PersonalDevelopment", new[]
            {
                "Mindfulness", "Meditation", "Stress management", "Emotional intelligence",
                "Self-motivation", "Self-discipline", "Goal setting", "Habit formation",
                "Journaling", "Speed reading", "Memory techniques", "Note-taking",
                "Organization", "Prioritization", "Financial literacy", "Investing",
                "Saving", "Debt management", "Retirement planning", "Insurance knowledge",
                "Tax planning", "Estate planning", "First aid", "CPR", "Survival skills",
                "Fire safety", "Water safety", "Road safety", "Personal security",
                "Self-defence", "Mind mapping", "Visual note-taking", "Speed learning",
                "Personal branding", "Self-reflection", "Self-care routines",
                "Assertive communication", "Conflict de-escalation", "Positive thinking",
                "Resilience building", "Adaptability", "Self-advocacy", "Digital detox",
                "Work-life balance", "Minimalism", "Gratitude practice"
            }, skills);

            // Health & Wellness Skills
            AddSkills(ref id, "HealthWellness", new[]
            {
                "Yoga", "Pilates", "Tai chi", "Meditation instruction", "Mindfulness coaching",
                "Nutrition planning", "Personal training", "Sports coaching", "Physiotherapy",
                "Massage therapy", "Aromatherapy", "Reflexology", "Herbal medicine",
                "Homeopathy", "Sleep hygiene", "Addiction counselling", "Mental health first aid",
                "Wellness coaching", "Life coaching", "Sports nutrition", "Injury prevention",
                "Rehabilitation exercises", "Athletic training", "Group fitness instruction",
                "Zumba teaching", "Spin class instruction", "Water aerobics", "Prenatal fitness",
                "Postnatal fitness", "Senior fitness", "Adaptive sports coaching",
                "Health screening", "Blood pressure monitoring", "Diabetes management",
                "Smoking cessation support", "Weight loss coaching", "Body composition analysis",
                "Wellness retreat planning"
            }, skills);

            // Legal & Regulatory Skills
            AddSkills(ref id, "LegalRegulatory", new[]
            {
                "Legal research", "Contract drafting", "Litigation support",
                "Compliance management", "Intellectual property management",
                "Trademark registration", "Patent filing", "Employment law", "Corporate law",
                "Tax law", "Environmental law", "GDPR compliance", "Anti-money laundering",
                "Due diligence", "Legal writing", "Case analysis", "Mediation", "Arbitration",
                "Legal negotiation", "Regulatory reporting", "Policy development",
                "Risk assessment", "Legal consulting"
            }, skills);

            // Education & Teaching Skills
            AddSkills(ref id, "EducationTeaching", new[]
            {
                "Lesson planning", "Curriculum development", "Classroom management",
                "Educational assessment", "Tutoring", "E-learning design", "Instructional design",
                "Online teaching", "Special education", "Early childhood education",
                "Adult education", "Language instruction", "STEM teaching", "Arts education",
                "Exam preparation", "Test marking", "Student counselling",
                "Educational technology", "Workshop facilitation", "Seminar hosting",
                "Training development", "Corporate training"
            }, skills);

            // Environmental & Sustainability Skills
            AddSkills(ref id, "EnvironmentalSustainability", new[]
            {
                "Recycling management", "Waste reduction", "Energy conservation",
                "Water management", "Sustainable agriculture", "Permaculture", "Organic farming",
                "Solar panel installation", "Wind energy systems", "Environmental impact assessment",
                "Wildlife conservation", "Habitat restoration", "Pollution control",
                "Carbon footprint analysis", "Green building design", "Eco-friendly product design",
                "Environmental policy analysis", "Climate change adaptation",
                "Environmental education", "Community sustainability projects",
                "Renewable energy consulting", "Sustainability reporting"
            }, skills);

            // Management & Leadership Skills
            AddSkills(ref id, "ManagementLeadership", new[]
            {
                "Strategic leadership", "Vision setting", "Delegation", "Motivation",
                "Team building", "Performance management", "Succession planning",
                "Organizational development", "Change leadership", "Stakeholder management",
                "Board governance", "Corporate social responsibility", "Crisis management",
                "Business transformation", "Innovation management", "Talent management",
                "Coaching for performance", "Diversity leadership", "Remote team management",
                "Cross-functional leadership", "Servant leadership", "Transformational leadership"
            }, skills);

            // Marketing & Branding Skills
            AddSkills(ref id, "MarketingBranding", new[]
            {
                "Brand strategy", "Market segmentation", "Consumer behaviour analysis",
                "Product positioning", "Advertising", "Content marketing", "Social media strategy",
                "Influencer partnerships", "Email marketing", "Affiliate marketing",
                "Event marketing", "Sponsorship management", "PR campaigns", "Media buying",
                "Marketing analytics", "Customer journey mapping", "Loyalty programme design",
                "Brand storytelling", "Reputation management", "Growth hacking",
                "Conversion rate optimization", "A/B testing", "Marketing automation",
                "Community management"
            }, skills);

            // Sales & Customer Service Skills
            AddSkills(ref id, "SalesCustomer Service", new[]
            {
                "Lead generation", "Cold calling", "Sales presentations", "Objection handling",
                "Closing techniques", "Account management", "Relationship selling",
                "Consultative selling", "Upselling", "Cross-selling", "CRM management",
                "Customer retention", "Complaint resolution", "Service recovery",
                "Customer feedback analysis", "Mystery shopping", "After-sales support",
                "Technical support", "Helpdesk management", "Customer onboarding",
                "Customer success management", "Client relations"
            }, skills);

            // Digital & Online Skills
            AddSkills(ref id, "DigitalOnline", new[]
            {
                "Website design", "Website management", "E-commerce setup",
                "Online payment systems", "Digital advertising", "Social media advertising",
                "Influencer outreach", "Online reputation management", "Podcast production",
                "Webinar hosting", "Virtual event management", "Online community management",
                "App monetization", "Affiliate programme management", "Online course creation",
                "Digital product development", "Mobile marketing", "Email automation",
                "Chatbot development", "Online survey creation", "Online moderation",
                "Forum administration", "Wiki editing", "Crowdsourcing management",
                "Online fundraising", "Digital archiving", "E-book publishing",
                "Online course facilitation", "Virtual assistant skills", "Remote collaboration",
                "Digital whiteboarding", "Online project management", "Virtual reality facilitation",
                "Online coaching", "Remote interviewing", "Online networking",
                "Webinar moderation", "Online event production", "Digital rights management",
                "E-learning analytics"
            }, skills);

            // Science & Research Skills
            AddSkills(ref id, "ScienceResearch", new[]
            {
                "Scientific method", "Hypothesis testing", "Experiment design", "Lab techniques",
                "Microscopy", "Chemical analysis", "Physics calculations", "Biology fieldwork",
                "Ecology studies", "Environmental monitoring", "Astronomy", "Meteorology",
                "Geology", "Genetics", "Anthropology", "Archaeology", "Psychology research",
                "Sociology research", "Literature review", "Data collection", "Field research",
                "Lab management", "Grant proposal writing", "Peer review", "Scientific publishing",
                "Data modelling", "Bioinformatics", "Genomics analysis", "Proteomics",
                "Clinical trials management", "Epidemiology", "Statistical programming",
                "Meta-analysis", "Research ethics", "Patent research", "Literature synthesis",
                "Survey design", "Experimental psychology", "Cognitive testing",
                "Behavioural analysis"
            }, skills);

            // Business & Entrepreneurship Skills
            AddSkills(ref id, "BusinessEntrepreneurship", new[]
            {
                "Business model design", "Startup pitching", "Venture capital raising",
                "Angel investing", "Business incubation", "Franchise management",
                "Licensing", "Crowdfunding", "Business valuation", "Market entry strategy",
                "Competitive analysis", "Lean startup methodology", "Product development",
                "MVP creation", "Go-to-market strategy", "Business scaling",
                "Exit strategy planning", "Business process reengineering", "Business automation",
                "Customer discovery", "Customer validation", "Pitch deck creation",
                "Investor relations", "Business storytelling", "Franchise development",
                "Licensing negotiation", "Strategic alliances", "Joint venture management",
                "Business planning", "Financial forecasting"
            }, skills);

            // Advanced Technical & Engineering Skills
            AddSkills(ref id, "Engineering", new[]
            {
                "Embedded systems programming", "Firmware development",
                "Microcontroller programming", "FPGA design", "PLC programming",
                "SCADA systems", "Industrial automation", "Mechatronics",
                "Aerospace engineering", "Automotive engineering", "Biomedical engineering",
                "Chemical process engineering", "Civil engineering design",
                "Structural engineering", "Geotechnical engineering",
                "Water resources engineering", "Environmental engineering", "HVAC design",
                "Power systems engineering", "Telecommunications engineering",
                "Signal processing", "Control systems", "Digital signal processing",
                "RF engineering", "Optical engineering"
            }, skills);

            // Home & Practical Skills
            AddSkills(ref id, "HomePractical", new[]
            {
                "Gardening", "Landscaping", "Plumbing", "Electrical repairs", "Carpentry",
                "Painting walls", "Wallpapering", "Tiling", "Flooring installation", "Roofing",
                "Masonry", "Welding", "Car maintenance", "Bicycle repair", "Appliance repair",
                "Sewing", "Laundry", "Ironing", "Cleaning", "Decluttering", "Home organization",
                "Meal planning", "Grocery shopping", "Budget cooking", "Food preservation",
                "Pickling", "Canning", "Composting", "Recycling", "Upcycling",
                "Smart home setup", "Home automation", "Solar panel maintenance",
                "Rainwater harvesting", "Greywater recycling", "DIY pest control",
                "Home insulation", "Energy auditing", "Home security systems",
                "CCTV installation", "Emergency preparedness", "Disaster recovery planning",
                "Home renovation", "Tiny house building", "Container home conversion",
                "Home staging", "Feng shui", "Interior styling", "Space optimization",
                "Home theatre setup"
            }, skills);

            // Sports & Outdoor Skills
            AddSkills(ref id, "SportsOutdoor", new[]
            {
                "Running", "Swimming", "Cycling", "Hiking", "Climbing", "Weightlifting",
                "CrossFit", "Aerobics", "Martial arts", "Boxing", "Kickboxing", "Judo",
                "Karate", "Taekwondo", "Fencing", "Archery", "Shooting", "Horse riding",
                "Rowing", "Sailing", "Surfing", "Skiing", "Snowboarding", "Ice skating",
                "Rollerblading", "Skateboarding", "Golf", "Tennis", "Table tennis",
                "Badminton", "Squash", "Basketball", "Football", "Rugby", "Cricket",
                "Baseball", "Softball", "Volleyball", "Orienteering", "Trail running",
                "Ultra-marathon training", "Triathlon training", "Open water swimming",
                "Lifeguarding", "Mountain biking", "BMX riding", "Parkour", "Free running",
                "Slacklining", "Disc golf", "Ultimate frisbee", "Handball", "Lacrosse",
                "Field hockey", "Curling", "Bobsleigh", "Skeleton racing", "Speed skating"
            }, skills);

            // Music & Performing Arts
            AddSkills(ref id, "MusicPerforming Arts", new[]
            {
                "Playing violin", "Playing cello", "Playing flute", "Playing saxophone",
                "Playing trumpet", "Playing clarinet", "Playing harmonica", "Playing banjo",
                "Playing ukulele", "Playing synthesizer", "Conducting", "Composing",
                "Arranging music", "Music production", "DJing", "Singing opera",
                "Musical theatre", "Directing", "Stage management", "Music theory",
                "Ear training", "Sight reading", "Improvisation", "Ensemble playing",
                "Orchestra participation", "Choir singing", "Voice acting", "Foley artistry",
                "Sound design", "Audio engineering", "Live sound mixing", "Stage lighting",
                "Stage sound setup", "Theatre production", "Musical direction",
                "Dance choreography", "Ballet", "Tap dancing", "Contemporary dance",
                "Hip-hop dance", "Ballroom dancing"
            }, skills);

            // Arts & Crafts
            AddSkills(ref id, "ArtsCrafts", new[]
            {
                "Textile design", "Pattern making", "Costume design", "Set design",
                "Prop making", "Mural painting", "Street art", "Graffiti techniques",
                "Mosaic creation", "Stained glass making", "Printmaking", "Lithography",
                "Silkscreen printing", "Etching", "Collage art", "Mixed media art",
                "Digital illustration", "Concept art", "Character design",
                "Storybook illustration", "Comic book art", "Manga illustration",
                "Infographic design", "Brochure design", "Poster design", "Book cover design",
                "Web banner design", "Motion graphics", "Stop-motion animation",
                "2D animation", "3D animation", "Video production", "Sound editing",
                "Colour grading", "Photo retouching", "Layout design", "Print production",
                "Packaging design", "Exhibition design"
            }, skills);

            // Lifestyle & Leisure Skills
            AddSkills(ref id, "LifestyleLeisure", new[]
            {
                "Cooking international cuisines", "Wine tasting", "Coffee brewing",
            "Baking bread", "Cheese making", "Home brewing", "Barista skills",
            "Food photography", "Travel planning", "Travel writing", "Backpacking",
            "Camping", "Birdwatching", "Stargazing", "Scuba diving", "Snorkelling",
            "Paragliding", "Skydiving", "Bungee jumping", "Map reading",
            "GPS navigation", "Trip planning", "Packing efficiently", "Booking travel",
            "Travel budgeting", "Cultural etiquette", "Travel photography",
            "Travel blogging", "RV driving", "Wilderness survival"
            }, skills);

            // Miscellaneous & Unique Skills
            AddSkills(ref id, "MiscellaneousUnique", new[]
            {
                "Speed cubing", "Memory championships", "Competitive gaming",
                "Esports coaching", "Drone piloting", "RC car racing", "Model building",
                "Lego engineering", "Puzzle solving", "Escape room design",
                "Magic performance", "Card tricks", "Juggling", "Unicycling", "Stilt walking",
                "Fire eating", "Sword swallowing", "Ventriloquism", "Puppetry",
                "Balloon modelling", "Sand art", "Ice carving", "Snow sculpting",
                "Kite making", "Kite flying", "Soap carving", "Fruit carving",
                "Cake sculpting", "Chocolate making", "Sugar art", "Candy making",
                "Perfume blending", "Tea blending", "Spice blending", "Herbal tincture making",
                "Essential oil blending", "Flower pressing", "Bonsai cultivation",
                "Aquarium keeping", "Terrarium building", "Beekeeping", "Falconry",
                "Dog training", "Cat training", "Horse whispering", "Parrot training",
                "Fish breeding", "Reptile care", "Exotic pet care", "Wildlife rehabilitation",
                "Animal rescue", "Animal fostering", "Charity volunteering",
                "Disaster relief volunteering", "Fundraising event planning",
                "Community outreach", "Public health education", "Political campaigning",
                "Speechwriting for leaders", "Policy analysis", "Think tank research",
                "Lifelong learning"
            }, skills);

            // Additional Market-Relevant Skills for African/Kenyan Context
            AddSkills(ref id, "AfricanMarket", new[]
            {
                "M-Pesa operations", "Mobile money management", "Matatu business management",
                "Boda boda fleet management", "Mpesa agent operations", "Chama management",
                "Microfinance operations", "Agricultural extension services",
                "Smallholder farming", "Horticulture export", "Tea farming", "Coffee farming",
                "Dairy farming", "Poultry farming", "Fish farming (aquaculture)",
                "Beekeeping (apiculture)", "Greenhouse farming", "Drip irrigation",
                "Post-harvest handling", "Agro-processing",
                "Community health work", "HIV/AIDS counselling", "Malaria prevention",
                "Tuberculosis management", "Maternal health services", "Child nutrition",
                "WASH (Water, Sanitation, Hygiene)", "Community mobilization",
                "Kiswahili translation", "Sheng interpretation", "Local language interpretation",
                "Cross-border trade", "Jua Kali metalwork", "Mitumba business",
                "Curio making", "Sisal basket weaving", "Kikoy textile production",
                "Maasai beadwork", "Cultural tourism guiding", "Safari guiding",
                "Wildlife photography", "Conservation education", "Community forest management",
                "Charcoal alternatives production", "Biogas installation",
                "Solar water heating", "Tuk-tuk driving", "Uber/Bolt driving",
                "Mama mboga business", "Kiosk management", "Hardware shop management",
                "Butchery operations", "Salon management", "Barbershop operations",
                "Tailoring", "Shoe repair (cobbling)", "Electronics repair",
                "Phone unlocking & repair", "Computer repair & maintenance",
                "Cybercafe management", "Printing & photocopying services",
                "Betting shop operations", "Liquor store management"
            }, skills);

            // Emerging Tech & Future Skills
            AddSkills(ref id, "EmergingTechnology", new[]
            {
                "AI prompt engineering", "ChatGPT consulting", "Midjourney art creation",
                "NFT creation & minting", "DAO management", "Web3 development",
                "Metaverse design", "Virtual world building", "AI ethics",
                "Quantum computing basics", "5G network deployment", "Edge computing",
                "Autonomous vehicle testing", "Drone delivery systems",
                "3D printing services", "Bioprinting", "Nanotechnology applications",
                "Augmented reality marketing", "Virtual influencing", "Digital twin creation",
                "Synthetic media detection", "Deepfake detection", "Carbon credit trading",
                "ESG reporting", "Impact investing analysis", "Circular economy consulting",
                "Zero-waste consulting", "Regenerative agriculture", "Urban farming",
                "Vertical farming", "Hydroponics", "Aeroponics", "Gene editing (CRISPR)",
                "Biohacking", "Longevity consulting", "Personalized medicine",
                "Telemedicine", "Remote patient monitoring", "Health data analytics",
                "Wearable tech integration", "Brain-computer interface development"
            }, skills);

            // Additional Professional Certifications & Specialized Skills
            AddSkills(ref id, "Certifications", new[]
            {
                "PMP certification", "Six Sigma Black Belt", "Lean Six Sigma",
                "PRINCE2", "CPA (Certified Public Accountant)", "CFA (Chartered Financial Analyst)",
                "ACCA", "CIMA", "CMA", "CIA (Certified Internal Auditor)",
                "CISSP", "CEH (Certified Ethical Hacker)", "CompTIA Security+",
                "AWS Certified Solutions Architect", "Microsoft Azure Administrator",
                "Google Cloud Certified", "Salesforce Administrator", "SAP consulting",
                "Oracle Database Administration", "Cisco CCNA", "Cisco CCNP",
                "ITIL certification", "Scrum Master certification", "Product Owner certification",
                "ISO 9001 auditing", "ISO 14001 auditing", "OHSAS 18001",
                "NEBOSH", "First Aid Instructor", "Wilderness First Responder",
                "Dive Master", "PADI Instructor", "Sommelier certification",
                "Personal trainer certification", "Nutritionist certification",
                "Clinical psychology", "Industrial psychology", "Educational psychology"
            }, skills);

            builder.Entity<Skill>().HasData(skills);

            void AddSkills(ref int currentId, string category, string[] skillNames, List<Skill> skillList)
            {
                foreach (var name in skillNames)
                {
                    skillList.Add(new Skill
                    {
                        Id = currentId++,
                        Name = name,
                        Category = category,
                        CreatedAt = DateTime.UtcNow
                    });
                }
            }
        }
    }
}
